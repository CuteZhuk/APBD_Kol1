using WebApplicationKol1.DtD;
using WebApplicationKol1.Models;

namespace WebApplicationKol1.Controllers;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


[ApiController]
[Route("api/player-teams")]
public class PlayerTeamsController : ControllerBase
{
    private readonly I_Db_Context _context;

    public PlayerTeamsController(I_Db_Context context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Player_Team>> AssignPlayerToTeam(Player_Team playerTeam)
    {
        var player = await _context.Players.FindAsync(playerTeam.IdPlayer);
        if (player == null)
        {
            return NotFound("Player not found");
        }
        
        var team = await _context.Teams.FindAsync(playerTeam.IdTeam);
        if (team == null)
        {
            return NotFound("Team not found");
        }

        var playerAge = DateTime.Now.Year - player.Dateof;
        if (playerAge > team.MaxAge)
        {
            return BadRequest("Player does not meet age requirements for the team");
        }
        
        using (var transaction = _context.Database.BeginTransaction())
        {
            try
            {
                await _context.PlayerTeams.AddAsync(playerTeam);
                await _context.SaveChangesAsync();

                transaction.Commit();
                return CreatedAtAction("", new { id = playerTeam.IdPlayerTeam }, playerTeam);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
