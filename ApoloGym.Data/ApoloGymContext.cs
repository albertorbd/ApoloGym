using Microsoft.EntityFrameworkCore;
using ApoloGym.Model;

namespace ApoloGym.Data
{
    public class ApoloGymContext : DbContext
    {
        public ApoloGymContext(DbContextOptions<ApoloGymContext> options)
            : base(options) {}

        public DbSet<User> Users { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }
        public DbSet<DietPlan> DietPlans { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
