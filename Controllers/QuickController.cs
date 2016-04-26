using System.Web.Http;

namespace quick.Controllers
{
    [RoutePrefix("api/quick")]
    public class QuickController : ApiController
    {
        [Route("get")]
        public IHttpActionResult Get()
        {
            return Ok(new { Name = "Quick" });
        }
    }
}
