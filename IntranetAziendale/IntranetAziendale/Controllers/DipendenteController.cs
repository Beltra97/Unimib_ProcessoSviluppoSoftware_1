using IntranetDAL.DMControllers;
using IntranetDAL.Requests;
using Microsoft.AspNetCore.Mvc;

namespace IntranetAziendale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DipendenteController : ControllerBase
    {
        DipendenteDMController controller = new DipendenteDMController();

        //CREATE DIPENDENTE 
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(RequestAddDipendente request)
        {
            if (controller.Add(request) != 0)
                return Ok(true);

            return Ok(false);
        }


        [Route("Get")]
        [HttpGet]
        public IActionResult Get()
        {
            var items = controller.Get();
            if (items != null)
                return Ok(items);

            return Ok(null);
        }


        [Route("Get/{id}")]
        [HttpGet]
        public IActionResult Get(int id)
        {
            var item = controller.GetByID(id);
            if (item != null)
                return Ok(item);

            return Ok(null);
        }


        [Route("Update/{id}")]
        [HttpPut]
        public IActionResult Update(int id, RequestAddDipendente request)
        {
            return Ok(controller.Update(id, request));
        }


        [Route("Delete/{id}")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return Ok(controller.Delete(id));
        }
    }
}
