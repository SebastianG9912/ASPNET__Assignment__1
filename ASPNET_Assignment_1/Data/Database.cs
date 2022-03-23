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
                new (){Name = "Sebastian", Email = "sebbe@hotmail.se", Phone_number = "0723456789"},
                new (){Name = "Emil", Email = "emil@gmail.com", Phone_number = "0729876543"},
                new (){Name = "Josefin", Email = "jossan@hotmail.com", Phone_number = "0722334455"}
            };
            await _ctx.Organizers.AddRangeAsync(organizersData);


        }

        public async Task RecreateDB()
        {
            await _ctx.Database.EnsureDeletedAsync();
            await _ctx.Database.EnsureCreatedAsync();
        }
    }
}
