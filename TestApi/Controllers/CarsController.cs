using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        public static List<Car> CarsList = new List<Car>();

        [HttpGet]
        public ActionResult<List<Car>> Get()
        {
            return Ok(CarsList);
        }

        [HttpPost]
        public ActionResult AddCar([FromBody] Car newCar)
        {
            CarsList.Add(newCar);

            return Ok($"Car with Rego {newCar.Rego} added");
        }

    }
}