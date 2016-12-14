using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonalDetails.Startup))]
namespace PersonalDetails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
