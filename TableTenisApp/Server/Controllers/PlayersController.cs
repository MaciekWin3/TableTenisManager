using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TableTenisApp.Shared.Database;
using TableTenisApp.Shared.Models;

namespace TableTenisApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        public IDapperDb _db;
        private readonly IHostEnvironment _environment;

        public PlayersController(IDapperDb db, IHostEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        [HttpGet]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public IEnumerable<Player> GetPlayers()
        {
            return _db.GetAllPlayers();
        }


        [HttpPost]
        public ActionResult<Player> CreatePlayer(Player player)
        {
            return _db.CreatePlayer(player);
        }

        [HttpDelete("{id}")]
        public void DeletePlayer(int id)
        {
            _db.DeletePlayer(id);
        }

        [HttpPut("{id}")]
        public ActionResult<Player> EditPlayerItem(Player player)
        {
            return _db.UpdatePlayer(player);
        }

        [HttpGet("{id}")]
        public ActionResult<Player> GetPlayerById(int id)
        {
            return _db.FindPlayerById(id);
        }

    }
}
