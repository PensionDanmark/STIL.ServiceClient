# STIL Soap helper library
Styrelsen for IT og Læring (STIL) exposes their services via SOAP.
The protocol used requires that the SOAP requests are signed with a certificate,
and that the underlying HTTP connection is secured with mTLS (a client certificate).

This poses a problem for clients on Microsofts .NET platform, as signed SOAP messages
are not supported on the newer .NET (Core) platform, only in the older .NET Framework
platform.

This library can help you create strongly-typed and signed SOAP XML requests
compatible with STIL in a way that is compatible with the newer .NET platform.

This does not use the WCF framework, but only relies only on ``HttpClient``.

To use this library you need to have a certificate for signing the message
that STIL will accept (typically an OCES certificate) and a certificate for
securing the HTTP call (mTLS). The same certificate may be suitable for
both uses, but that depends on your setup.

Out of the box the library also comes with some pre-built requests and
responses. In the initial version, those would be the ones the authors needed
in their initial application launch. These prebuilt requests and corresponding
responses are exposed by the ``StilVeuServiceClient``.

If you need to integrate with some of the other services exposed at
``integrationsplatformen.dk`` that are not currently supported, we encourage
you to make a pull request to add the missing functionality. Use the
implementation of ``StilVeuServiceClient`` as a guide to what to do.

If you decide you want to completely implement your own client instead, you
can take a look in the ``Util\SoapHelper`` folder. The code in this location
is what does the heavy lifting to go from a DTO request object to a SOAP
request that STIL will accept.

## How to use
### Using the prebuilt client
If you happen to only require the already data implemented by
``StilVeuServiceClient``, you can simply instantiate this class (or add it
from dependency injection (see ``Extensions\ServiceCollectionExtensions.cs``))
with a suitable certificate that STIL knows about and you should be good to
go. See the ``DTOs`` folder for the currently supported operations.

If the operation you need it not one of the ones implemented, you'll need
to use a raw HTTP POST operation to STIL instead, see the example below.

### Using a raw request
In this example we'll assume you want to use the same certificate for signing the SOAP
as well as securing the http connection. First attach  the client certificate to a
http client:
```csharp
HttpClient GetHttpClientWithCertificateForSTIL(string certificateThumbprint)
{
  // Load from Cert Store or KeyVauly, etc.
  var certificate = GetCertificateFromThumbprint(certificateThumbprint);
  var handler = new HttpClientHandler()
  {
    ClientCertificates = { certificate }
  };
  
  // Alternatively: create a reusable one instead of new'ing up one
  var httpClientForStil = new HttpClient(handler);
  
  return httpClientForStil;
}
```

Then you build your `DTO` request and use the `SignedStilSoapMessage` to construct the
XML SOAP message:

```csharp
T request = BuildStronglyTypedRequest();

var certThumbprint = GetClientCertThumbprintFromConfig();
var clientCert = GetCertificate(certThumbprint);
var stilRequest = SignedStilSoapMessage<T>(request);

var signedRequest = stilRequest.GetSignedXml(clientCert);
```

### **Do not reformat the XML after this, as you will invalidate the signature!** 

Just use the signed SOAP XML as content to the `HttpClient` and send it to STIL:

```csharp

var httpClient = GetHttpClientWithCertificateForSTIL(certThumbprint);
var content = new StringContent(signedRequest, Encoding.UTF8, "application/soap+xml");

// SOAP uses POST messages. 
var httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://....");
httpRequest.Content = content;

var response = await client.SendAsync(httpRequest, HttpCompletionOption.ResponseHeadersRead);
var reply = await response.Content.ReadAsStringAsync();
```

The `reply` will now contain the SOAP response XML from STIL. You can then pick out
the `Body` element, which will contain the actual response object. If you have the need
you can also handle Faults as well.
