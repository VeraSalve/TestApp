using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestApp.Data;
using System;
using System.Linq;

namespace TestApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TestAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TestAppContext>>()))
            {
                // Look for any movies.
                if (context.Worker.Any())
                {
                    return;   // DB has been seeded
                }
            }
        }

    }
}
