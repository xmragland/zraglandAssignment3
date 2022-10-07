using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using zraglandAssignment3.Models;

namespace zraglandAssignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<zraglandAssignment3.Models.Movie> Movie { get; set; }
        public DbSet<zraglandAssignment3.Models.Actor> Actor { get; set; }
        public DbSet<zraglandAssignment3.Models.ActorMovie> ActorMovie { get; set; }
    }
}