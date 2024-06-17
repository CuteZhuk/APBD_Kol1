using System.ComponentModel.DataAnnotations;
using WebApplicationKol1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationKol1.DtD;

public class I_Db_Context
{
    public DbSet<Championship> Championships { get; set; }
    public DbSet<Championship_Team> ChampionshipTeams { get; set; }
    public DbSet<Player_Team> PlayerTeams { get; set; }
    public DbSet<Players> Players { get; set; }
    public DbSet<Team> Teams { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Championship_Team>()
            .HasKey(ct => new { ct.IdChampionshipTeam });

        modelBuilder.Entity<Championship_Team>()
            .HasOne(ct => ct.Championship)
            .WithMany()
            .HasForeignKey(ct => ct.IdChampionship);

        modelBuilder.Entity<Championship_Team>()
            .HasOne(ct => ct.Team)
            .WithMany()
            .HasForeignKey(ct => ct.IdTeam);

        modelBuilder.Entity<Player_Team>()
            .HasKey(pt => new { pt.IdPlayerTeam });

        modelBuilder.Entity<Player_Team>()
            .HasOne(pt => pt.Player)
            .WithMany()
            .HasForeignKey(pt => pt.IdPlayer);

        modelBuilder.Entity<Player_Team>()
            .HasOne(pt => pt.Team)
            .WithMany()
            .HasForeignKey(pt => pt.IdTeam);
    }
}
