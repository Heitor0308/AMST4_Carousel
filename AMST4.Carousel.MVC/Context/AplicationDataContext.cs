using Microsoft.EntityFrameworkCore;
using AMST4.Carousel.MVC.Models;

namespace AMST4.Carousel.MVC.Context
{
    public class AplicationDataContext : DbContext
    {
        public AplicationDataContext(DbContextOptions<AplicationDataContext> options) : base(options) { }

        public DbSet<Category> Category { get; set; }
    }
}