using System;
using System.Collections.Generic;

namespace RPS.Models
{
    public interface IRPSGameRepository
    {
        Guid? addGame(Guid PlayerID, int maxScore);
        List<RPSGame> getGames();
        RPSGame getGameByPlayerID(Guid playerID);
        RPSGame getGameByID(Guid gameID);
    }
}