using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuggestionBox.Startup))]
namespace SuggestionBox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
