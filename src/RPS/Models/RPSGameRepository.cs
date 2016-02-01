using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.Models
{
    public class RPSGameRepository : IRPSGameRepository
    {
        private List<RPSGame> games= new List<RPSGame>();

        public Guid? addGame(Guid PlayerID, int maxScore)
        {
            //verify if player is already playing a game
            if(games.Where<RPSGame>(g => g.PlayerID==PlayerID).Count<RPSGame>()>0)
            {
                return null;
            }

            RPSGame game = new RPSGame();  //new guid generated here
            game.PlayerID = PlayerID;
            game.playerScore = 0;
            game.serverScore = 0;
            game.maxScore = maxScore;
            games.Add(game);

            return game.GameID;
        }


        public List<RPSGame> getGames()
        {
            return games;
        }

        public RPSGame getGameByID(Guid gameID)
        {
            return games.Where(g => g.GameID == gameID).FirstOrDefault();
        }

        public RPSGame getGameByPlayerID (Guid playerID)
        {
            
            RPSGame game=games.Where(g => g.PlayerID == playerID).FirstOrDefault();
            return game;
        }

    }
        
}
