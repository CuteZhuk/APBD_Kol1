using WebApplicationKol1.DtD;
using WebApplicationKol1.Models;

namespace WebApplicationKol1.Controllers;

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

[ApiController]
[Route("api/championships/{championshipId}/teams")]
public class ChampionshipTeamsController : ControllerBase
{
    private readonly I_Db_Context _context;

    public ChampionshipTeamsController(I_Db_Context context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Championship_Team>>> GetChampionshipTeams(int championshipId)
    {
        var championshipTeams = await _context.ChampionshipTeams
            .Where(ct => ct.IdChampionship == championshipId)
            .ToListAsync();

        if (championshipTeams == null || championshipTeams.Count == 0)
        {
            return NotFound();
        }

        return Ok(championshipTeams);
    }
}