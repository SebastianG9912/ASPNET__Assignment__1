using ASPNET_Assignment_1.Controllers;
using ASPNET_Assignment_1.Models;

namespace ASPNET_Assignment_1.Data
{
    public class Database
    {
        private readonly EventDbContext _ctx;

        public Database(EventDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Seed()
        {
            var organizersData = new Organizer[]
            {
                new (){Name = "GoodCorp", Email = "gcorp@hotmail.se", Phone_number = "0723456789"},
                new (){Name = "Utekompaniet", Email = "utekomp@gmail.com", Phone_number = "0729876543"},
                new (){Name = "PartyFolk!", Email = "party@hotmail.com", Phone_number = "0722334455"}
            };
            

            var eventInfoData = new EventInfo[]
            {
                new (){Title = "DaydreamCoding", Date=DateTime.Now + TimeSpan.FromDays(30), Location = "Halmstad", Organizer = organizersData[0]},
                new (){Title = "Våningsfesten", Date=DateTime.Now + TimeSpan.FromDays(5), Location = "Göteborg", Organizer = organizersData[0]},
                new (){Title = "Grillhäng", Date=DateTime.Now + TimeSpan.FromDays(365), Location = "Norrköpng", Organizer = organizersData[1]},

            };

            var attendeeData = new Attendee[]
            {
                new (){Name = "Sebastian", Email = "sebbe@hotmail.com", Phone_number = "0721112223"},
                new (){Name = "Emil", Email = "emil@gmail.se", Phone_number = "0729999999"},
                new (){Name = "Josefin", Email = "jossan@gmail.com", Phone_number = "0725555555"}
            };

            var firstAttendeeEvents = new AttendeeEventInfo[]
            {
                new (){Attendee = attendeeData[0], EventInfo = eventInfoData[0]},
                new (){Attendee = attendeeData[0], EventInfo = eventInfoData[1]},
            };
            attendeeData[0].AttendeeEventInfos = new List<AttendeeEventInfo>(firstAttendeeEvents);
            
            var secondAttendeeEvents = new AttendeeEventInfo[]
            {
                new (){Attendee = attendeeData[1], EventInfo = eventInfoData[0]},
            };
            attendeeData[1].AttendeeEventInfos = new List<AttendeeEventInfo>(secondAttendeeEvents);

            await _ctx.Organizers.AddRangeAsync(organizersData);
            await _ctx.SaveChangesAsync();
            await _ctx.EventInfos.AddRangeAsync(eventInfoData);
            await _ctx.SaveChangesAsync();
            await _ctx.Attendees.AddRangeAsync(attendeeData);
            await _ctx.SaveChangesAsync();

        }

        public async Task RecreateDb()
        {
            await _ctx.Database.EnsureDeletedAsync();
            await _ctx.Database.EnsureCreatedAsync();
        }
    }
}
