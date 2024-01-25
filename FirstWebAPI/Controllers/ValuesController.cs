using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public ValuesController() { }

        [HttpGet]
        public Cars GetCar()
        {
            Cars obj = new Cars();

            obj.id = 1;
            obj.carname = "BMW";

            return obj;

        }
    }
}
