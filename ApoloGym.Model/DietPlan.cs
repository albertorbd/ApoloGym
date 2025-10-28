using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApoloGym.Model;

public class DietPlan
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string? DietName { get; set; }

    [MaxLength(1000)]
    public string? DietDescription { get; set; }

    [Required]
    public string? DietJson { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [JsonIgnore]
    public User? User { get; set; }

    public DietPlan() { }
    public DietPlan(int userId, string dietName, string dietDescription, string dietJson)
    {
        UserId = userId;
        DietName = dietName;
        DietDescription = dietDescription;
        DietJson = dietJson;
    }
}


