// See https://aka.ms/new-console-template for more information
using Azure.Core;
using EntityFrameworkRepetition.Database;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

MinContext context = new();
context.Database.EnsureCreated(); // Kör migrations vid behov
// Check if migrations are needed
//if (context.Database.GetPendingMigrations().Any())
//{
//    // Run migrations
//    context.Database.Migrate();
//}

context.People.Add(
    new Models.Person
    {
        Name = "Kalle",
        Address="Blahagatan 4",
        City="Blabla city",
        Pets = new List<Models.Pet>
            { new Models.Pet
                { Name = "Doggo" , Type="Dog"} 
            }
    });
context.SaveChanges();