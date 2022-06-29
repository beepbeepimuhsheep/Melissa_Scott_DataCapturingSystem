using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Melissa_Scott_9189_IPG521_FA1_Final.Startup))]
namespace Melissa_Scott_9189_IPG521_FA1_Final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
