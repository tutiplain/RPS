using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<Player> players = new List<Player>();
        public bool addPlayer(string name)
        {
            Player p = new Player();
            p.gamesWon = 0;
            p.playerName = name;


            //verify existence
            if(players.Where<Player>(pl => pl.playerName==name).Count<Player>()>0)
            {
                return false;
            }

            players.Add(p);
            return true;
        }

        public List<Player> getPlayers()
        {
            return players;
        }

        public Player getPlayerByID(Guid id)
        {
            return players.Where(p => p.PlayerID == id).FirstOrDefault();
        }

        public Player getPlayerByName(string name)
        {
            return players.Where(p => p.playerName == name).FirstOrDefault();

        }
    }
}
