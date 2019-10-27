using IntranetDAL.DMControllers;
using Microsoft.AspNetCore.Mvc;

namespace IntranetAziendale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RuoloController : ControllerBase
    {
        RuoloDMController controller = new RuoloDMController();

        [Route("Get")]
        [HttpGet]
        public IActionResult Get()
        {
            var items = controller.Get();
            if (items != null)
                return Ok(items);

            return Ok(null);
        }
    }
}