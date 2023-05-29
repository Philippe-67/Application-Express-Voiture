using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Application_Express_Voiture.Models;

namespace Application_Express_Voiture.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Application_Express_Voiture.Models.Reparation> Reparation { get; set; } = default!;
        public DbSet<Application_Express_Voiture.Models.Voiture> Voiture { get; set; } = default!;
    }
}