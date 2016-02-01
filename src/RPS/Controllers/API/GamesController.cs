using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using RPS.Models;
using RPS.Services;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RPS.Controllers.API
{
    [Route("api/[controller]")]
    public class GamesController : Controller
    {

        public IRPSGameRepository _gameRepo;


        public GamesController(IRPSGameRepository repo)
        {
            _gameRepo = repo; 
        }

        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_gameRepo.getGames());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public JsonResult Get([FromForm] Guid GameID)
        {
            return Json(_gameRepo.getGameByID(GameID));
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromForm]Guid PlayerID, int score)
        {
            if(ModelState.IsValid)
            {
                Guid? newGameID = _gameRepo.addGame(PlayerID, score);
                if (newGameID.HasValue)
                {
                    return Json(new { GameID = newGameID.Value, message="Use this id to invoke the play API!"  });
                }
                else
                {
                    return Json(new { error = "Player is already playing a game. Please try again later!" });
                }
            }
            else
            {
                return Json(new { error = "Model state was not valid" });
            }
            

        }

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
