using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LearnDotNetCore.Models
{
    public class BlogDbContext : DbContext
    {

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {
            
        }

        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var artEnt = modelBuilder.Entity<Article>();

            artEnt.HasKey(a => a.Id);
            artEnt.Property(a => a.Content).IsRequired().HasMaxLength(300);
            artEnt.Property(a => a.Name).IsRequired();
            artEnt.Property(a => a.PublicationDate).IsRequired();
            artEnt.Property(a => a.RowVersion).IsConcurrencyToken();

            base.OnModelCreating(modelBuilder);
        }
    }
}
