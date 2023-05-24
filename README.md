# STIL Soap helper library
This library can help you create strongly-typed and signed SOAP XML requests 
compatible with STIL.

Styrelsen for IT og Læring (STIL) exposes their services via SOAP.
The protocol used requires that the SOAP requests are signed with a certificate,
and that the underlying HTTP connection is secured with mTLS (a client certificate).

This poses a problem for clients on Microsofts .NET platform, as signed SOAP messages
are not supported on the newer .NET Core platform, only in the older .NET Framework
platform.

This library can create a SOAP request that STIL will accept. In order to use it,
you need to have a certificate for signing the message that STIL will accept (typically
a VOCES certificate) and a certificate for securing the HTTP call (mTLS). The same
certificate may be suitable for both uses, but that depends on your setup.

## How to use
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
  var stilClient = new HttpClient(handler);
  
  return stilClient;
}
```

Then you build your `DTO` request and use the `StilSoapMessage` to construct the
XML SOAP message:

```csharp
T request = BuildStronglyTypedRequest();

var certThumbprint = GetClientCertThumbprintFromConfig();
var clientCert = GetCertificate(certThumbprint);
var stilRequest = StilSoapMessage<T>(request);

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
