using GuzelRandevu.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuzelRandevu.Data
{
    public class ApplicationDbContext : IdentityDbContext<Uye>
    {
        public DbSet<GuzellikMerkezi> GuzellikMerkezi { get; set; }
        public DbSet<Randevu> Randevu { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Randevu>()
       .HasKey(r => new { r.merkezId, r.uyeId });
            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.guzellikMerkezi)
                .WithMany(g => g.randevular)
                .HasForeignKey(r => r.merkezId);
            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.uye)
                .WithMany(u => u.randevular)
                .HasForeignKey(r => r.uyeId);
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
