using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MTG.Models;

namespace MTG.Data
{
    public class dBaseContext : DbContext
    {
        public dBaseContext(DbContextOptions<dBaseContext> options) : base(options)
        {
        }
        public DbSet<Login> login { get; set; }
        public DbSet<Productos> productos { get; set; }
        public DbSet<Deposito> deposito { get; set; }
        public DbSet<Stock> stock { get; set; }
        public DbSet<Movimiento> movimiento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().ToTable("Login");
            modelBuilder.Entity<Productos>().ToTable("Productos");
            modelBuilder.Entity<Deposito>().ToTable("Deposito");
            modelBuilder.Entity<Stock>().ToTable("Stock");
            modelBuilder.Entity<Movimiento>().ToTable("Movimiento");
        }
    }
}
