using System.Collections.Generic;
using TableTenisApp.Shared.Models;

namespace TableTenisApp.Shared.Database
{
    public interface IDapperDb
    {
        Player CreatePlayer(Player player);
        void DeletePlayer(int id);
        bool DoesEmailExists(string email);
        bool DoesPlayerExists(int id);
        Player FindPlayerById(int id);
        List<Player> GetAllPlayers();
        List<Player> GetTopThreePlayers();
        Player UpdatePlayer(Player player);
    }
}