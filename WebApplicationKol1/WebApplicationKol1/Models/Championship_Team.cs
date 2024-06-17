namespace WebApplicationKol1.Models;

public class Championship_Team
{
    public int IdChampionshipTeam { get; set; }
    public int IdTeam { get; set; }
    public int IdChampionship { get; set; }
    public float Score { get; set; }

    public Championship_Team(int idChampionshipTeam, int idTeam, int idChampionship, float score)
    {
        IdChampionship = idChampionship;
        IdChampionshipTeam = idChampionshipTeam;
        IdTeam = idTeam;
        Score = score;
    }
}