using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.Models
{
    public class PlayerRepository : IPlayerRepository
    {
        private List<Player> players;
        public bool addPlayer(string name)
        {
            Player p = new Player();
            p.gamesWon = 0;
            p.playerName = name;

            players.Add(p);
            return true;
        }

        public List<Player> getPlayers()
        {
            return players;
        }
    }
}
