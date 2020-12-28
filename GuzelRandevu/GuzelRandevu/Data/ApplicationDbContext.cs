using GuzelRandevu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuzelRandevu.Data
{
    public class ApplicationDbContext : IdentityDbContext<Musteri>
    {
        public DbSet<GuzellikMerkezi> GuzellikMerkezi { get; set; }
        public DbSet<Randevu> Randevu { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Randevu>()
                .HasKey(cs => new { cs.merkezNoId, cs.musteriNoId });
        }
    }
}
