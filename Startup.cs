using Microsoft.Owin;
using Owin;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

[assembly: OwinStartup(typeof(quick.Startup))]

namespace quick
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configure(config => {                
                var jSettings = new JsonSerializerSettings();
                jSettings.Formatting = Formatting.Indented;
                jSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                config.Formatters.Remove(config.Formatters.XmlFormatter);
                config.Formatters.JsonFormatter.SerializerSettings = jSettings;
            });

        }
    }
}
