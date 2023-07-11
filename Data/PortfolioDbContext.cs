using Microsoft.EntityFrameworkCore;
using JeanPortFolio.Models;

namespace JeanPortFolio.Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
    }
}
