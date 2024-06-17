namespace WebApplicationKol1.Models;

public class Team
{
    public int IdTeam { get; set; }
    public string TeamName { get; set; }
    public int MaxAge { get; set; }

    public Team(int idTeam, string teamName, int maxAge)
    {
        IdTeam = idTeam;
        TeamName = teamName;
        MaxAge = maxAge;
    }
}