using System.ComponentModel.DataAnnotations;


namespace ApoloGym.Model;


public class WorkoutPlan
{

    [Key]
    public int Id { get; set; }
    [Required]
    public int UserId { get; set; }
    [Required]
    public string WorkoutName { get; set; }
    [Required]
    public string WorkoutDescription { get; set; }

    public string WorkoutDuration { get; set; }

    public string WorkoutJson { get; set; }

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public User? User { get; set; }

    public WorkoutPlan() { }

    public WorkoutPlan( int userId, string workoutName, string workoutDescription, string workoutDuration, string workoutJson )
    {

        UserId = userId;
        WorkoutName = workoutName;
        WorkoutDescription = workoutDescription;
        WorkoutDuration = workoutDuration;
        WorkoutJson = workoutJson;

    }
}