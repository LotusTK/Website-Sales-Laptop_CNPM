using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalTerm_CNPM.Models
{
    public class FinalTermContext : DbContext
    {
        public FinalTermContext() : base(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = FinalTerm_CNPM; Integrated Security = True")
        {
           
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Cpu> Cpus { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProducts> CartProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProducts> OrderProducts { get; set; }
    }
}