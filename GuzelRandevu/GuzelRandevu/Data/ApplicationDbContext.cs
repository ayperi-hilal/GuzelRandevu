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
        .HasKey(bc => new { bc.merkezNoId, bc.musteriNoId });
            modelBuilder.Entity<Randevu>()
                .HasOne(bc => bc.merkez)
                .WithMany(b => b.randevular)
                .HasForeignKey(bc => bc.merkezNoId);
            modelBuilder.Entity<Randevu>()
                .HasOne(bc => bc.musteri)
                .WithMany(c => c.randevular)
                .HasForeignKey(bc => bc.musteriNoId);
        }
    }
}
