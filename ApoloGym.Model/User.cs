using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApoloGym.Model;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Lastname { get; set; }
    [Required]
    public string Password { get; set; }
    [Required]
    public string Email { get; set; }
    [Phone]
    public string? Phone { get; set; }

    public ICollection<Membership> Memberships { get; set; }
    public WorkoutPlan? WorkoutPlan { get; set; }
    public DietPlan? DietPlan { get; set; }

    public User() { }

    public User(string name, string lastname, string email, string password)
    {
    Name = name;
    Lastname = lastname;
    Email = email;
    Password = password;
    }

}