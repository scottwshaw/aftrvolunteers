using System.Data.Entity;

namespace AFTRVolunteersWeb.Models
{
    public class VolunteerContext : DbContext
    {
        public VolunteerContext() : base("DefaultConnection")
        {
        }
        public DbSet<Person> People { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Stall> Stalls { get; set; }
    }
}