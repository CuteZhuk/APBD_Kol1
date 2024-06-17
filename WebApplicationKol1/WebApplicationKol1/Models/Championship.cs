namespace WebApplicationKol1.Models;

public class Championship
{
    public int IdChampions { get; set;  }
    public string OfficalName { get; set; }
    public int Year { get; set; }

    public Championship(int idChampions, string officalName, int year)
    {
        IdChampions = idChampions;
        OfficalName = officalName;
        Year = year;
    }
}