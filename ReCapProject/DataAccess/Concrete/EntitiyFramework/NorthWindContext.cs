using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntitiyFramework
{
    public class NorthWindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReCapDb;Trusted_Connection=true");
        }
        public DbSet <Car> Cars { get; set; }
        public DbSet <Card> Cards { get; set; }
        public DbSet <Brand> Brands { get; set; }
        public DbSet <Color> Colors { get; set; }
        public DbSet <Customer> Customers { get; set; }
        public DbSet <Rental> Rentals { get; set; }
        public DbSet <CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserR> UsersR { get; set; }
        public DbSet<UserOperationClaim> UserOperationsClaims { get; set; }
    }
}
