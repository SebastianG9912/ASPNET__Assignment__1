using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNET_Assignment_1.Models
{
    public class Organizer
    {
        [Key] public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone_number { get; set; }


        public ICollection<EventInfo>? EventInfos { get; set; }
    }
}
