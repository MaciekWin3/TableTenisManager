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
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PlayersController : ControllerBase
    {
        public IDapperDb _db;
        private readonly IHostEnvironment _environment;

        public PlayersController(IDapperDb db, IHostEnvironment environment)
        {
            _db = db;
            _environment = environment;
        }

        [AllowAnonymous]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Player))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Player>> GetPlayers()
        {
            try
            {
                return _db.GetAllPlayers();
            }
            catch(Exception e)
            {
                while (e.InnerException != null)
                {
                    e = e.InnerException;
                }                    
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }        
        }

        [AllowAnonymous]
        [HttpGet, Route("chart")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Player))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Player>> GetChartData()
        {
            try
            {
                return _db.GetTopThreePlayers();
            }
            catch (Exception e)
            {
                while (e.InnerException != null)
                {
                    e = e.InnerException;
                }
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Player> CreatePlayer(Player player)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            try
            {
                bool exist = _db.DoesEmailExists(player.Email);
                if (!exist)
                {
                    return _db.CreatePlayer(player);
                }
                else
                {
                    return StatusCode(StatusCodes.Status409Conflict, "Player with that email already exists"); 
                }

            }
            catch (Exception e)
            {
                while (e.InnerException != null)
                {
                    e = e.InnerException;
                }

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
                     
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Player))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Player> DeletePlayer(int id)
        {

            bool exist = _db.DoesPlayerExists(id);

            if (exist)
            {
                try
                {
                    _db.DeletePlayer(id);
                    return Ok("Player deleted");
                }
                catch (Exception e)
                {
                    while (e.InnerException != null)
                    {
                        e = e.InnerException;
                    }

                    return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
                }
            }

            return NotFound($"Player with this id does not exists: {id}");        
            
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Player))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Player> EditPlayerItem(Player player)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool exist = _db.DoesPlayerExists(player.Id);

            if (exist)
            {
                try
                {
                    return _db.UpdatePlayer(player);
                }
                catch (Exception e)
                {
                    while (e.InnerException != null)
                    {
                        e = e.InnerException;
                    }

                    return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
                }
            }

            return NotFound($"Player with this id does not exists: {player.Id}");

        }

        [HttpGet("{id}")]
        public ActionResult<Player> GetPlayerById(int id)
        {
            try
            {
                bool exists = _db.DoesPlayerExists(id);
                if (exists)
                {
                    return _db.FindPlayerById(id);
                }
                else
                {
                    return NotFound($"Player with {id} id does not exists");
                }
            }
            catch(Exception e)
            {
                while (e.InnerException != null)
                {
                    e = e.InnerException;
                }
                    

                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }           
        }



    }
}
