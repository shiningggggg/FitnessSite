using Microsoft.Owin;
using Owin;
[assembly:OwinStartup(typeof(Fitness.WebUi.Startup))]
namespace Fitness.WebUi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigurationAuth(app);
        }    
    }
}