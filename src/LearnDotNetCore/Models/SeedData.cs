using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LearnDotNetCore.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlogDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BlogDbContext>>()))
            {
                // Look for any movies.
                if (context.Articles.Any())
                {
                    return;   // DB has been seeded
                }

                context.Articles.AddRange(
                    new Article
                    {
                        Content = "dsadsadasdas",
                        Id = 1,
                        Name = "Art1",
                        PublicationDate = DateTime.Now
                    },
                    new Article
                    {
                        Content = "blebl",
                        Id = 2,
                        Name = "art2",
                        PublicationDate = DateTime.Now.AddDays(-2)
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
