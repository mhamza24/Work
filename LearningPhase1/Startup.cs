using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningPhase1.Startup))]
namespace LearningPhase1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
