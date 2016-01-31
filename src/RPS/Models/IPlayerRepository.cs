using System.Collections.Generic;

namespace RPS.Models
{
    public interface IPlayerRepository
    {
        bool addPlayer(string name);
        List<Player> getPlayers();
    }
}