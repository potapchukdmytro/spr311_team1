using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using team1.Models;

namespace team1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
