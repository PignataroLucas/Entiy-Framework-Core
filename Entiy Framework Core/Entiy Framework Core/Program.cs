using Api.Scripts;
using Microsoft.EntityFrameworkCore;

var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite().Options;
var dbContext = new ApplicationDbContext(options);

dbContext.Database.Migrate();

void ProcessInsert()
{
    var address = new Address() { City = "Buenos Aires", Street = "Serrano", Zip = "1828", HouseNumber = 12 };
    var professor = new Professor() { FirstName = "Lucas", LastName = "Doe", Address = address };
    
}