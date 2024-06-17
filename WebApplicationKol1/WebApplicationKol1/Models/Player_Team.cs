namespace WebApplicationKol1.Models;

public class Player_Team
{
    public int IdPlayerTeam { get; set; }
    public int IdPlayer { get; set; }
    public int IdTeam { get; set; }
    public int NumOnShir { get; set; }
    public string Comment { get; set; }

    public Player_Team(int idPlayerTeam, int idPlayer, int idTeam, int numOnShir, string comment)
    {
        IdPlayerTeam = idPlayerTeam;
        IdPlayer = idPlayer;
        IdTeam = idTeam;
        NumOnShir = numOnShir;
        Comment = comment;
    }
}