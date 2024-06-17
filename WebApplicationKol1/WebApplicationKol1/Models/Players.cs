namespace WebApplicationKol1.Models;

public class Players
{
    public int IdPlayer { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Dateof { get; set; }

    public Players(int idPlayer, string firstName, string lastName, int dateof)
    {
        IdPlayer = idPlayer;
        FirstName = firstName;
        LastName = lastName;
        Dateof = dateof;
    }
}