using System.Data.Entity;

namespace AFTRVolunteersWeb.Models
{
    public class VolunteerContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Stall> Stalls { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stall>().HasOptional(t => t.Owner);
            modelBuilder.Entity<Stall>().HasMany(t => t.TimeSlots).WithOptional();
        }
    }
}