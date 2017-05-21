using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using IdentityServer3.Core.Configuration;
using Microsoft.Owin;
using Owin;
using TripCompany.IdentityServer.Config;

[assembly: OwinStartup(typeof(TripCompany.IdentityServer.Startup))]

namespace TripCompany.IdentityServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/identity", idsrvApp =>
            {
                var idServerServiceFactory = new IdentityServerServiceFactory()
                    .UseInMemoryClients(Clients.Get())
                    .UseInMemoryScopes(Scopes.Get())
                    .UseInMemoryUsers(Users.Get());
                var options=new IdentityServerOptions
                {
                    Factory = idServerServiceFactory,
                    SiteName = "TripCompany Security Token Service",
                    IssuerUri = TripGallery.Constants.TripGalleryIssuerUri,
                    PublicOrigin = TripGallery.Constants.TripGallerySTSOrigin,
                    SigningCertificate = LoadCertificate()
                };
                idsrvApp.UseIdentityServer(options);
            });
        }

        X509Certificate2 LoadCertificate()
        {
            return new X509Certificate2($@"{AppDomain.CurrentDomain.BaseDirectory}\certificates\idsrv3test.pfx", "idsrv3test");
        }
    }
}
