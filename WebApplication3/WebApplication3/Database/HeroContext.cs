
namespace WebApplication3.Database
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Models;
    public class HeroContext : DbContext
    {
        private const string DatabaseName = "Heroes";
        public DbSet<Hero> Heroes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                $@"Server = .\SQLEXPRESS;Database={DatabaseName};trusted_connection=true");
        }
    }
}
