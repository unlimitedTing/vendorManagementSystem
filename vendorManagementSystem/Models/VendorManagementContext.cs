using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using vendorManagementSystem.Models;

namespace vendorManagementSystem.Models
{
    public class VendorManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<UserEvent> UserEvents { get; set; }

        public VendorManagementContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEvent>()
                .HasRequired(ue => ue.User)
                .WithMany(u => u.UserEvents)
                .HasForeignKey(ue => ue.UserId);

            modelBuilder.Entity<UserEvent>()
                .HasRequired(ue => ue.Event)
                .WithMany(e => e.UserEvents)
                .HasForeignKey(ue => ue.EventId);
        }
    }

}