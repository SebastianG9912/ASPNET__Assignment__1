using System.ComponentModel.DataAnnotations;

namespace ASPNET_Assignment_1.Models
{
    public class EventInfo
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public Organizer Organizer { get; set; }

        public ICollection<AttendeeEventInfo>? AttendeeEventInfo { get; set; }
    }
}
