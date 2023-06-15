using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using STIL.ServiceClient.ConfigurationProviders;
using STIL.ServiceClient.Extensions;
using System.Security.Cryptography.X509Certificates;

namespace STIL.ServiceClient.Tests.VEU
{
    public class ServiceCollectionExtensionsTests
    {
        [Fact]
        public void AddStilVeuServiceClient_WithConfiguration_AddsServiceToCollection()
        {
            // Arrange
            var services = new ServiceCollection();
            var inMemorySettings = new Dictionary<string, string> {
                {"Stil:BaseUrl", "https://test.com"},
                {"Stil:ClientCertificateThumbprint", "client-thumbprint"},
                {"Stil:SigningCertificateThumbprint", "signing-thumbprint"},
            };
            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings!)
                .Build();

            var certificateProviderMock = new Mock<ICertificateProvider>();
            certificateProviderMock.Setup(c => c.GetCertificateByThumbprint(It.IsAny<string>()))
                .Returns(new X509Certificate2());

            // Act
            services.AddStilVeuServiceClient(configuration, certificateProviderMock.Object);

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var stilVeuServiceClient = serviceProvider.GetService<IStilVeuServiceClient>();
            stilVeuServiceClient.Should().NotBeNull("because the IStilVeuServiceClient should be registered in the service collection");
        }

        [Fact]
        public void AddStilVeuServiceClient_WithNoCertificateFound_ThrowsArgumentNullException()
        {
            // Arrange
            var services = new ServiceCollection();
            var inMemorySettings = new Dictionary<string, string> {
                {"Stil:BaseUrl", "https://test.com"},
                {"Stil:ClientCertificateThumbprint", "client-thumbprint"},
                {"Stil:SigningCertificateThumbprint", "signing-thumbprint"},
            };
            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings!)
                .Build();

            // Act
            services.AddStilVeuServiceClient(configuration);

            // Assert
            var serviceProvider = services.BuildServiceProvider();
            var exception = Assert.Throws<ArgumentNullException>(() => serviceProvider.GetService<IStilVeuServiceClient>());
            exception.Message.Should().StartWith("No certificate was found in store location 'My:CurrentUser' with thumbprint: 'client-thumbprint'. The following certificates are available:");
        }

        [Fact]
        public void AddStilVeuServiceClient_WithNoSigningCertificateFound_ThrowsArgumentNullException()
        {
            // Arrange
            var services = new ServiceCollection();
            var inMemorySettings = new Dictionary<string, string> {
                {"Stil:BaseUrl", "https://test.com"},
                {"Stil:ClientCertificateThumbprint", "client-thumbprint"},
            };
            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings!)
                .Build();

            // Act
            var exception = Assert.Throws<ArgumentNullException>(() => services.AddStilVeuServiceClient(configuration));
            
            // Assert
            exception.Message.Should().Be("SigningCertificateThumbprint is as minimum required in the Stil configuration section, for using this dependency registration. (Parameter 'SigningCertificateThumbprint')");
        }

        [Fact]
        public void AddStilVeuServiceClient_WithNoBaseUrlFound_ThrowsArgumentNullException()
        {
            // Arrange
            var services = new ServiceCollection();
            var inMemorySettings = new Dictionary<string, string> {
                {"Stil:ClientCertificateThumbprint", "client-thumbprint"},
            };
            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings!)
                .Build();

            // Act
            var exception = Assert.Throws<ArgumentNullException>(() => services.AddStilVeuServiceClient(configuration));

            // Assert
            exception.Message.Should().Be("BaseUrl var not provided in the Stil configuration section. (Parameter 'BaseUrl')");
        }
    }
}
