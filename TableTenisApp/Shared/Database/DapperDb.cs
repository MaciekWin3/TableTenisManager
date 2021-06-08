using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTenisApp.Shared.Models;
using Dapper;

namespace TableTenisApp.Shared.Database
{
    public class DapperDb : IDapperDb
    {
        private IDbConnection db;

        public DapperDb(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("TableTenisDatabase"));
        }

        public List<Player> GetAllPlayers()
        {
            var sql = "Select * from Players";
            return db.Query<Player>(sql).ToList();
        }

        public Player FindPlayerById(int id)
        {
            var sql = "SELECT * FROM players WHERE id = @id";
            return db.Query<Player>(sql, new { @id = id }).Single();
        }

        public void DeletePlayer(int id)
        {
            var sql = "DELETE FROM players WHERE id = @Id";
            db.Execute(sql, new { id });
        }

        public Player CreatePlayer(Player player)
        {

            var sql = $"insert into players Values(@firstname, @surname,@email, @picturepath, @country, @dateofbirth, @points)";

            var record = db.Query(sql, new
            {
                player.FirstName,
                player.Surname,
                player.Email,
                player.PicturePath,
                player.Country,
                player.DateOfBirth,
                player.Points
            });

            return player;
        }

        public Player UpdatePlayer(Player player)
        {
            var sql = "UPDATE players SET firstname = @firstname, surname = @surname, email = @email, PicturePath = @picturepath, country = @country, dateofbirth = @dateofbirth, points = @points  where id = @Id";
            db.Execute(sql, player);
            return player;
        }


    }
}
