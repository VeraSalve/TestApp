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

            Database.EnsureCreated();
        }

        public DbSet<TestApp.Models.Workers> Worker { get; set; } = default!;

        public DbSet<TestApp.Models.Print_queque> Print_Queque { get; set; } = default!;

        public DbSet<TestApp.Models.Status_of_print> Print_Status {  get; set; } = default!;

        public TestAppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Spodrychniy;Trusted_Connection=True;MultipleActiveResultSets=true");

        }
    }
}
