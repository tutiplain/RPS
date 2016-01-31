using System;
using System.Collections.Generic;

namespace RPS.Models
{
    public interface IRPSGameRepository
    {
        bool addGame(Guid PlayerID, int maxScore);
        List<RPSGame> getGames();
    }
}