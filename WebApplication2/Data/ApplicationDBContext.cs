using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data.Enum;
using WebApplication2.Models;
using WebApplication2.Models.Club;
using WebApplication2.Models.Race;
using WebApplication2.Models.User;

namespace WebApplication2.Data
{
    public class ApplicationDBContext: IdentityDbContext<User>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Race>? Races { get; set; }
        public DbSet<Club>? Clubs { get; set; }

        public DbSet<Address>? Addresses { get; set; }
        public DbSet<User>? Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure primary key for IdentityUserLogin<string> entity
            modelBuilder.Entity<IdentityUserLogin<string>>(b =>
            {
                b.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            });

            // Configure primary key for IdentityUserRole<string> entity
            modelBuilder.Entity<IdentityUserRole<string>>(b =>
            {
                b.HasKey(r => new { r.UserId, r.RoleId });
            });

            // Configure primary key for IdentityUserToken<string> entity
            modelBuilder.Entity<IdentityUserToken<string>>(b =>
            {
                b.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            });

            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                Street = "123 Main St",
                City = "New York",
                PostalCode = "10001",
                State = "NY"
            },
            new Address
            {
                Id = 2,
                Street = "456 Elm St",
                City = "Los Angeles",
                PostalCode = "90001",
                State = "CA"
            },
    new Address
    {
        Id = 3,
        Street = "789 Oak St",
        City = "Chicago",
        PostalCode = "60601",
        State = "IL"
    },
    new Address
    {
        Id = 4,
        Street = "321 Pine St",
        City = "Houston",
        PostalCode = "77001",
        State = "TX"
    }, new Address
    {
        Id = 5,
        Street = "567 Maple St",
        City = "Miami",
        PostalCode = "33101",
        State = "FL"
    }, new Address
    {
        Id = 6,
        Street = "890 Cedar St",
        City = "Seattle",
        PostalCode = "98101",
        State = "WA"
    }, new Address
    {
        Id = 7,
        Street = "234 Birch St",
        City = "Boston",
        PostalCode = "02101",
        State = "MA"
    }, new Address
    {
        Id = 8,
        Street = "876 Walnut St",
        City = "San Francisco",
        PostalCode = "94101",
        State = "CA"
    });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Rebecca Osuagwu",
                Email = "Reb@gmail.com",
                Password = "jdahfaodao",
                AddressId = 3
            },
            new User
            {
                Id = 2,
                Name = "Owen Hagreaves",
                Email = "OwenHargereaves@gmail.com",
                Password = "owndealtio",
                AddressId = 4
            }, new User
            {
                Id = 3,
                Name = "Matthew Oakson",
                Email = "jane@example.com",
                Password = "examplepassword2",
                AddressId = 5
            },new User
            {
                Id = 4,
                Name = "Matthew Oakson",
                Email = "jane@example.com",
                Password = "examplepassword2",
                AddressId = 3
            });

            modelBuilder.Entity<Club>().HasData(new Club
            {
                Id = 1,
                Title = "Endurance Club",
                Description = "For those who seek endurance challenges",
                Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                AddressId = 2,
                ClubCategory = ClubCategory.Endurance,
                UserId = 2
            }, new Club
            {
                Id = 2,
                Title = "Speed Racing Club",
                Description = "For those who love speed and adrenaline",
                Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
                AddressId = 5,
                ClubCategory = ClubCategory.RoadRunner,
                UserId = 3
            },
    new Club
    {
        Id = 3,
        Title = "Adventure Club",
        Description = "Exploring the great outdoors and challenging terrains",
        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
        AddressId = 7,
        ClubCategory = ClubCategory.City,
        UserId = 2
    },
    new Club
    {
        Id = 4,
        Title = "Fitness Club",
        Description = "Promoting health and fitness through various activities",
        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
        AddressId = 8,
        ClubCategory = ClubCategory.Trail,
        UserId = 3
    });


            
            modelBuilder.Entity<Race>().HasData(new Race
            {
             Id = 1,
             Title = "formula 1",
             Description = "Cross country race",
             Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
             StartTime = DateTime.Now,
             EntryFee = 500,
              Website = "WWW.getRaceCourse",
             Twitter= "@twiRace",
              Facebook = "race face",
              Contact = "not yet",
             AddressId  = 1,
             RaceCategory = RaceCategory.FiveK,
             UserId = 1
    },
    new Race
    {
        Id = 2,
        Title = "formula 1 pro",
        Description = "country race",
        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
        StartTime = DateTime.Now,
        EntryFee = 2000,
        Website = "WWW.getRaceCoursenew",
        Twitter = "@twiRace2",
        Facebook = "race face2",
        Contact = "not yet",
        AddressId = 2,
        RaceCategory = RaceCategory.Marathon,
        UserId = 2
    }, new Race
    {
        Id = 3,
        Title = "Sprint Challenge",
        Description = "Short-distance running race",
        Image = "https://www.eatthis.com/wp-content/uploads/sites/4/2020/05/running.jpg?quality=82&strip=1&resize=640%2C360",
        StartTime = DateTime.Now.AddHours(1),
        EntryFee = 1000,
        Website = "www.sprintchallenge.com",
        Twitter = "@SprintChallenge",
        Facebook = "SprintChallenge",
        Contact = "Jane Doe",
        AddressId = 3,
        RaceCategory = RaceCategory.HalfMarathon,
        UserId = 3
    });
        }
    }
}
