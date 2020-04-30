using App.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Context
{
    public class EFContext : IdentityDbContext
    {
        public EFContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.\SQLEXPRESS01;database=LocalTraderDB;trusted_connection=true;");
        }
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<ProductOrderModel> ProductsOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsumerModel>();
            /*
                .HasOne(x => x.Address)
            .WithOne(x => x.Consumer)
            .HasForeignKey<AddressModel>(x => x.ConsumerId);
             */

            modelBuilder.Entity<ProductModel>();
            modelBuilder.Entity<OrderModel>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
