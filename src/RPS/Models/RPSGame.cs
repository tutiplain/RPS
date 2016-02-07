using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPS.Services;

namespace RPS.Models
{
    public class RPSGame
    {
        private IRandomNumberService _rnd;

        public RPSGame(IRandomNumberService rnd)
        {
            this.GameID = Guid.NewGuid();
            _rnd = rnd;
        }

        public int playerScore { get; set; }
        public int serverScore { get; set; }
        public Guid GameID { get; set; }
        public Guid PlayerID { get; set; }
        public int maxScore { get; set; }



        private string[][] possibilities = new string[][] {
            new string[] {"Rock"     , "Rock"    , "Draw!"                            , "draw"},
            new string [] {"Rock"    , "Paper"   , "Paper envelops rock, you win!"    , "win"},
            new string[] {"Rock"     , "Scissors", "Rock destroys scissors, you lose!", "lose"},
            new string[] {"Paper"    , "Rock"    , "Paper envelops rock, you lose!"   , "lose"},
            new string [] {"Paper"   , "Paper"   , "Draw!"                            , "draw"},
            new string[] {"Paper"    , "Scissors", "Scissors cut paper, you win!"     , "win"},
            new string [] {"Scissors", "Rock"    , "Rock destroys scissors, you win!" , "win"},
            new string [] {"Scissors", "Paper"   , "Scissors cut paper, you lose!!"   , "lose"},
            new string [] {"Scissors", "Scissors", "Draw!"                            , "draw"}
        };

        public object play(string playerChoice)
        {

            int serverChoice = _rnd.getRandom(0, 3);
            string serverObject = "";
            switch (serverChoice)
            {
                case 0:
                    serverObject = "Rock";
                    break;
                case 1:
                    serverObject = "Paper";
                    break;
                case 2:
                    serverObject = "Scissors";
                    break;
            }

            int x;
            string action = "";
            string result = "";
            for (x = 0; x < this.possibilities.Length; x++)
            {
                string[] p = possibilities[x];
                if (p[0] == serverObject && p[1] == playerChoice)
                {
                    action = p[2];
                    result = p[3];

                }
            }

            if (result == "win") { this.playerScore++; }
            if (result == "lose") { this.serverScore++; }

            return new { action=action, stats=this.gameStats() };
        }


        public object gameStats()
        {
            return new { GameID = this.GameID, serverScore = this.serverScore, playerScore = this.playerScore };
        }
    }

}

