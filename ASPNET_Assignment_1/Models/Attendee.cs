using System.ComponentModel.DataAnnotations;

namespace ASPNET_Assignment_1.Models
{
    public class Attendee
    {
        [Key] public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }

        public string Phone_number { get; set; }

        public ICollection<AttendeeEventInfo>? AttendeeEventInfos { get; set; }


    }
}
