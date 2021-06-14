using HomeAccounting.BusinesLogic.EF.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAccounting.BusinesLogic.EF.AppLogic
{
    public class DomainContext : DbContext
    {
        private readonly String _connectionString = "Host=localhost; Username=postgres; Password=qwerty; Database=postgres;";
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyPriceChange> PricesChanged { get; set; }
        public DbSet<Deposit> Deposites { get; set; }

        //public DomainContext()
        //{
        //    Database.EnsureDeleted();
        //}

        public DomainContext(DbContextOptions<DomainContext> opt): base(opt)
        {
            Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            base.OnConfiguring(optionBuilder);
            optionBuilder.UseNpgsql();
        }            

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Bank>();
            modelBuilder.Entity<Deposit>().ToTable("Deposits");
            modelBuilder.Entity<Operation>().HasMany<Account>(x => x.Accounts);
            modelBuilder.Entity<Property>().ToTable("Properties").HasMany<PropertyPriceChange>(x => x.PropertyPriceChange);
            modelBuilder.Entity<PropertyPriceChange>();
            modelBuilder.Entity<Cash>().ToTable("Cashes");
        }
    }
}
