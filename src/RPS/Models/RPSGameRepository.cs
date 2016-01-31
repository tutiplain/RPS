using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.Models
{
    public class RPSGameRepository : IRPSGameRepository
    {
        private List<RPSGame> games;

        public bool addGame(Guid PlayerID, int maxScore)
        {
            RPSGame game = new RPSGame();  //new guid generated here
            game.PlayerID = PlayerID;
            game.playerScore = 0;
            game.serverScore = 0;
            game.maxScore = maxScore;
            games.Add(game);

            return true;
        }


        public List<RPSGame> getGames()
        {
            return games;
        }
    }
        
}
