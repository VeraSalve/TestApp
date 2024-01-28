using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Data
{
    public class TestAppContext : DbContext
    {
        public TestAppContext (DbContextOptions<TestAppContext> options)
            : base(options)
        {
        }

        public DbSet<TestApp.Models.Workers> Worker { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Spodrychniy;Trusted_Connection=True;MultipleActiveResultSets=true");

        }
    }
}
