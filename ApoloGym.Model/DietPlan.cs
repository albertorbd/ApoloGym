using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApoloGym.Model;

public class DietPlan
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [MaxLength(1000)]
    public string? Description { get; set; }

    [Required]
    public string? DietJson { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public User? User { get; set; }

    public DietPlan() { }
    public DietPlan(int userId, string name, string description, string dietJson)
    {
        UserId = userId;
        Name = name;
        Description = description;
        DietJson = dietJson;
    }
}


