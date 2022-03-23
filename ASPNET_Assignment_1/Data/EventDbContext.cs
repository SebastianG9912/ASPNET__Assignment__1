using ASPNET_Assignment_1.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNET_Assignment_1.Data
{
    public class EventDbContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<EventInfo> EventInfos { get; set; }

        public EventDbContext(DbContextOptions<EventDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AttendeeEventInfo>()
                .HasKey(ae => new {ae.AttendeeId, ae.EventId});//Composite key

            builder.Entity<AttendeeEventInfo>()
                .HasOne(ae => ae.Attendee)
                .WithMany(a => a.AttendeeEventInfos)
                .HasForeignKey(ae => ae.AttendeeId);

            builder.Entity<AttendeeEventInfo>()
                .HasOne(ae => ae.EventInfo)
                .WithMany(e => e.AttendeeEventInfos)
                .HasForeignKey(ae => ae.EventId);
        }
    }
}
