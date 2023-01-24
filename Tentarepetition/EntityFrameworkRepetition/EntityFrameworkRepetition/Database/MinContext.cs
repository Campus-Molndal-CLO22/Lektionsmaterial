namespace EntityFrameworkRepetition.Database;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class MinContext : DbContext // DbContext är en klass för att kommunicera med databasen
{
    public DbSet<Models.Person> People { get; set; } // DBSet är en klass som representerar en tabell i databasen
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        // OnConfiguring är en metod som anropas när DbContext skapas
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MinDb;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Person>().HasMany(p => p.Pets).WithMany(p => p.Owners);
        base.OnModelCreating(modelBuilder);
    }
}
