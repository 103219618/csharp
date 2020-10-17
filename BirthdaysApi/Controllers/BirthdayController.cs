using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BirthdaysApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BirthdayController : ControllerBase
    {
        static public List<Person> People = new List<Person>();

        public BirthdayController()
        {

        }

        [HttpGet("GetList()")]
        public int GetList()
        {
            return People;
        }
    }
}