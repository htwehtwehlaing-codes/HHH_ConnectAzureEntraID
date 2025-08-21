using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Identity.Web.OWIN;
using Microsoft.Identity.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using Microsoft.Identity.Web.TokenCacheProviders.InMemory;

[assembly: OwinStartup(typeof(HHH_ConnectAzureEntraID.Startup))]

namespace HHH_ConnectAzureEntraID
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions());
            OwinTokenAcquirerFactory factory = TokenAcquirerFactory.GetDefaultInstance<OwinTokenAcquirerFactory>();

            app.AddMicrosoftIdentityWebApp(factory);
            factory.Services
                .Configure<ConfidentialClientApplicationOptions>(options => { options.RedirectUri = "https://localhost:44368"; })
                .AddMicrosoftGraph()
                .AddInMemoryTokenCaches();
            factory.Build();

        }

    }
}
