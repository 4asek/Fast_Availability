using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Box> Boxes { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<TrackLog> TrackLogs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.Property(e => e.Price)
                    .HasPrecision(18, 2);

            });
            modelBuilder.Entity<Box>(entity =>
            {

                entity.Property(e => e.Price)
                    .HasPrecision(18, 2);
            });
            modelBuilder.Entity<Shipment>()
              .HasOne(s => s.DepartmentSender)
              .WithMany(d => d.SentShipments)
              .HasForeignKey(s => s.DepartmentSenderId)
              .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Shipment>()
              .HasOne(s => s.DepartmentReceiver)
              .WithMany(d => d.ReceivedShipments)
              .HasForeignKey(s => s.DepartmentReceiverId)
              .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}
