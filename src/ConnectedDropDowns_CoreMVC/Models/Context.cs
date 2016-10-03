using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectedDropDowns_CoreMVC.Models
{
    public class DropDownDbContext : DbContext
    {
        public DropDownDbContext() { }
        public DropDownDbContext(DbContextOptions<DropDownDbContext> options) : base(options) { }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DropDown_Core;Trusted_Connection=True;");
        //}

        //OR Add The Code Below to Startup.cs ConfigureServices
        //var connection = @"Server=(LocalDb)\MSSQLLocalDB;Database=DropDown_Core;Trusted_Connection=True;";
        //services.AddDbContext<DropDownDbContext>(options => options.UseSqlServer(connection));
    }
    public static class SeedData
    {
        //app.Seed(); //Add This Code to Startup.cs Configure 
        
        public static void Seed(this IApplicationBuilder app)
        {
            //var context = app.ApplicationServices.GetService<DropDownDbContext>();

            //context.Countries.Add(new Country { ID = "1", Name = "United States" });
            //context.Countries.Add(new Country { ID = "2", Name = "Canada" });
            //context.Countries.Add(new Country { ID = "3", Name = "Australia" });


            //context.States.Add(new State { ID = "1", Name = "Florida", CountryId = "1" });
            //context.States.Add(new State { ID = "2", Name = "Nevada", CountryId = "1" });
            //context.States.Add(new State { ID = "3", Name = "California", CountryId = "1" });
            //context.States.Add(new State { ID = "4", Name = "Ontario", CountryId = "2" });
            //context.States.Add(new State { ID = "5", Name = "Quebec", CountryId = "2" });
            //context.States.Add(new State { ID = "6", Name = "New Brunswick", CountryId = "2" });
            //context.States.Add(new State { ID = "7", Name = "Queensland", CountryId = "3" });
            //context.States.Add(new State { ID = "8", Name = "Tasmania", CountryId = "3" });


            //context.Cities.Add(new City { ID = "1", Name = "Miami", StateId = "1" });
            //context.Cities.Add(new City { ID = "2", Name = "Orlando", StateId = "1" });
            //context.Cities.Add(new City { ID = "3", Name = "Jacksonville", StateId = "1" });
            //context.Cities.Add(new City { ID = "4", Name = "Las Vegas", StateId = "2" });
            //context.Cities.Add(new City { ID = "5", Name = "Reno", StateId = "2" });
            //context.Cities.Add(new City { ID = "6", Name = "Carson City", StateId = "2" });
            //context.Cities.Add(new City { ID = "7", Name = "Los Angeles", StateId = "3" });
            //context.Cities.Add(new City { ID = "8", Name = "Sacramento", StateId = "3" });
            //context.Cities.Add(new City { ID = "9", Name = "Riverside", StateId = "3" });
            //context.Cities.Add(new City { ID = "10", Name = "Toronto", StateId = "4" });
            //context.Cities.Add(new City { ID = "11", Name = "Ottawa", StateId = "4" });
            //context.Cities.Add(new City { ID = "12", Name = "Niagara Falls", StateId = "4" });
            //context.Cities.Add(new City { ID = "13", Name = "Quebec City", StateId = "5" });
            //context.Cities.Add(new City { ID = "14", Name = "Montreal", StateId = "5" });
            //context.Cities.Add(new City { ID = "15", Name = "Trois-Rivières", StateId = "5" });
            //context.Cities.Add(new City { ID = "16", Name = "Edmunston", StateId = "6" });
            //context.Cities.Add(new City { ID = "17", Name = "Saint John", StateId = "6" });
            //context.Cities.Add(new City { ID = "18", Name = "Campbellton", StateId = "6" });
            //context.Cities.Add(new City { ID = "19", Name = "Brisbane", StateId = "7" });
            //context.Cities.Add(new City { ID = "20", Name = "Mackay", StateId = "7" });
            //context.Cities.Add(new City { ID = "21", Name = "Townsville", StateId = "7" });
            //context.Cities.Add(new City { ID = "22", Name = "Devonport", StateId = "8" });
            //context.Cities.Add(new City { ID = "23", Name = "Launceston", StateId = "8" });
            //context.Cities.Add(new City { ID = "24", Name = "Strahan", StateId = "8" });

            //context.SaveChanges();
        }
    }
}
