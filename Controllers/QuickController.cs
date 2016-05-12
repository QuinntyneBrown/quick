using quick.Dtos;
using System.Web.Http;
using System.Web.Http.Description;

namespace quick.Controllers
{
    [RoutePrefix("api/quick")]
    public class QuickController : ApiController
    {
        [Route("get")]
        [HttpGet]
        [ResponseType(typeof(QuickDto))]
        public IHttpActionResult Get()
        {
            return Ok(new QuickDto() { Message = "Quick Message" });
        }
    }
}
