
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApoloGym.Model;

public class Membership
{

    [Key]
    public int Id { get; set; }
    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    [Required]
    public string Type { get; set; }
    [Required]
    [DataType(DataType.Currency)]
    public double Price { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    [Required]
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }
    [Required]
    public string Status { get; set; }
    
    [JsonIgnore]
    public User? User { get; set; }

    public Membership() { }
    
    public Membership(int userId, string type, double price, DateTime startDate, DateTime endDate)
    {
        UserId = userId;
        Type = type;
        Price = price;
        StartDate = startDate;
        EndDate = endDate;
        Status = "Active";   
    }
}