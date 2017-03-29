using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TheNicestWebApp.Models;

namespace TheNicestWebApp.Data
{
    public class WebSampleData
    {

        public async static Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetService<ApplicationDbContext>();
            await db.Database.EnsureCreatedAsync();
            if (!db.Persons.Any())
            {
                db.Persons.AddRange(
                new Person { Id = 1, FirstName = "Lesley", LastName = "Wayne", Title = "President", Description = "My goal is to provide opportunity for every single person on our team and I won’t stop until I have helped every member of our team hit their goals."}
                );

                }
            if (!db.Addresses.Any())
                 {
                db.Addresses.AddRange(
                new Address { Id = 1, City = "Seattle", State = "WA", Zip = 98101 }
                );
            }
            
            db.SaveChanges();
        }
    }
}
