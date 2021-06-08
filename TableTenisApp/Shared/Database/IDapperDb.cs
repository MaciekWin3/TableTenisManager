using System.Collections.Generic;
using TableTenisApp.Shared.Models;

namespace TableTenisApp.Shared.Database
{
    public interface IDapperDb
    {
        Player CreatePlayer(Player player);
        void DeletePlayer(int id);
        Player FindPlayerById(int id);
        List<Player> GetAllPlayers();
        Player UpdatePlayer(Player player);
    }
}