using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.Models
{
    public class Player
    {

        public Player()
        {
            this.PlayerID = Guid.NewGuid();
        }

        public Guid PlayerID { get; set; }
        public string playerName{ get; set; }
        public int  gamesWon { get; set; }

    }
}
