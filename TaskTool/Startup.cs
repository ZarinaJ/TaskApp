using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskTool.Startup))]
namespace TaskTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
