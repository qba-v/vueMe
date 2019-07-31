using Domain.DTO;
using Microsoft.EntityFrameworkCore;

namespace Domain.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
