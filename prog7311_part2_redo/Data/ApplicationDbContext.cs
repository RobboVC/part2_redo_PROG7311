using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using prog7311_part2_redo.Models;

namespace prog7311_part2_redo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<prog7311_part2_redo.Models.Farmer>? Farmer { get; set; }
        public DbSet<prog7311_part2_redo.Models.Product>? Product { get; set; }
    }
}