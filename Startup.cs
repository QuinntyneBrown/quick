using Owin;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Microsoft.Owin;
using Swashbuckle.Application;

[assembly: OwinStartup(typeof(quick.Startup))]

namespace quick
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            

            GlobalConfiguration.Configure(config => {
                config.MapHttpAttributeRoutes();
                var jSettings = new JsonSerializerSettings();
                jSettings.Formatting = Formatting.Indented;
                jSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                config.Formatters.Remove(config.Formatters.XmlFormatter);
                config.Formatters.JsonFormatter.SerializerSettings = jSettings;
            });

        }
    }
}
