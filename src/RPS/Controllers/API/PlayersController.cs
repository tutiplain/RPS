using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RPS.Models;
// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RPS.Controllers.API
{
    [Route("api/[controller]")]
    public class PlayersController : Controller
    {

        private IPlayerRepository _playerRepo;

        public PlayersController(IPlayerRepository repo)
        {
            _playerRepo = repo;
        }

        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_playerRepo.getPlayers());   
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get(Guid id)
        {
            return Json(_playerRepo.getPlayerByID(id));            
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromForm] string name)
        {
            if(ModelState.IsValid)
            {
                bool added = _playerRepo.addPlayer(name);
                if (!added)
                {
                    return Json(new { error = "A player with that name already exists" });
                }
                else
                {
                    Player newPlayer = _playerRepo.getPlayerByName(name);
                    return Json(newPlayer);
                }
            }
            else
            {
                return Json(new { error="Model was not valid"});
            }
            
        }


        //TODO: implement deleting and updating players
        // PUT api/values/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
