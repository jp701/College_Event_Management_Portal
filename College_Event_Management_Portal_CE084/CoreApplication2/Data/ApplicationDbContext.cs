using System;
using System.Collections.Generic;
using System.Text;
using CoreApplication2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Event_Management_DB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<EventProgram>()
                .HasOne<ClgEvent>(p=> p.ClgEvent)
                .WithMany(c=> c.EventPrograms)
                .HasForeignKey(p => p.EventId)
                .HasPrincipalKey(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<RegEvent>()
                .HasOne<ApplicationUser>(r => r.User)
                .WithMany(u => u.RegEvents)
                .HasForeignKey(r => r.UserId)
                .HasPrincipalKey(r => r.Id)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<RegEvent>()
                .HasOne<ClgEvent>(r => r.Event)
                .WithMany(u => u.RegEvents)
                .HasForeignKey(r => r.EventId)
                .HasPrincipalKey(r => r.Id)
                .OnDelete(DeleteBehavior.Cascade);
            /* builder.Entity<ClgEvent>()
                 .Property(b => b.Status)
                 .HasDefaultValue(0); //by default new event*/
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ClgEvent> ClgEvents { get; set; }
        public DbSet<EventProgram> EventPrograms { get; set; }
        public DbSet<RegEvent> RegEvents { get; set; }
    }
}
