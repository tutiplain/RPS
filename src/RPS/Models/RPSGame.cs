using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPS.Models
{
    public class RPSGame
    {

        public RPSGame()
        {
            this.GameID = Guid.NewGuid();
        }

        public int playerScore { get; set; }
        public int serverScore { get; set; }
        public Guid GameID { get; set; }
        public Guid PlayerID { get; set; }
        public int maxScore { get; set; }

    }
}
