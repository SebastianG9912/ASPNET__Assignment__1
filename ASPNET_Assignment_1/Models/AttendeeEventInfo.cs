namespace ASPNET_Assignment_1.Models
{
    public class AttendeeEventInfo
    {
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }

        public int EventId { get; set; }
        public EventInfo EventInfo { get; set; }
    }
}
