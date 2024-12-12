using Microsoft.AspNetCore.Mvc;
using PlayerApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace PlayerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTopPlayers()
        {
            // נתוני דוגמה
            var players = new List<Player>
            {
                new Player{ PlayerName = "מיכאל", PlayerScore = 1289, PlayerPosition = 1, PlayerMedia ="https://imgur.com/Ic9ePG9"},
                new Player{ PlayerName = "אופיר", PlayerScore = 1189, PlayerPosition = 2, PlayerMedia ="https://imgur.com/mI68wUa"},
                new Player{ PlayerName = "יעל", PlayerScore = 800, PlayerPosition = 3, PlayerMedia ="https://imgur.com/WGHRpnf"}
            };

            // מיון לפי PlayerPosition
            var sortedPlayers = players.OrderBy(p => p.PlayerPosition).ToList();

            // מחזיר את הנתונים בפורמט JSON
            return Ok(new { top4Players = sortedPlayers });
        }
    }
}
