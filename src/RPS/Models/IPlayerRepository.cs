using System.Collections.Generic;
using System;

namespace RPS.Models
{
    public interface IPlayerRepository
    {
        bool addPlayer(string name);
        List<Player> getPlayers();
        Player getPlayerByID(Guid id);
        Player getPlayerByName(string name);
    }
}