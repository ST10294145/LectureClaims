using LectureClaims.Models;
using Microsoft.EntityFrameworkCore;

namespace LectureClaims.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }
    }
}
