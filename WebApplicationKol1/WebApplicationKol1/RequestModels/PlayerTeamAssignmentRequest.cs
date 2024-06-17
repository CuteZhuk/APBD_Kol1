using System.ComponentModel.DataAnnotations;

namespace WebApplicationKol1.RequestModels;

public class PlayerTeamAssignmentRequest
{
    [Required]
    public int PlayerId { get; set; }
    public int TeamId { get; set; }
    public int NumberOnShirt { get; set; }
    public string Comment { get; set; }
}
