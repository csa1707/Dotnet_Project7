using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController1 : ControllerBase
    {

        public ValuesController1() { }

        [HttpGet]
        public Vegetable GetVegetable()
        {
            Vegetable obj = new Vegetable();

            obj.eid = 1;
            obj.vegname = "onion";
            obj.cost = 100;

            return obj;
        }
    }
}
