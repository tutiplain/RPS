using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RPS.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RPS.Controllers
{
    [Route("api/[controller]")]
    public class RandomController : Controller
    {

        IRandomNumberService _rnd;

        public RandomController(IRandomNumberService rnd)
        {
            _rnd = rnd;
        }


        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(new { number = _rnd.getRandom(0, 10) });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
