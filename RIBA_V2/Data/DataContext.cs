using System;
using Microsoft.EntityFrameworkCore;
using RIBA_V2.Entities;

namespace RIBA_V2
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        // thought sqlite db with entity framework best
        // tried inmemorydb however, due to programming with a mac m1,
        // visual studio .net for mac m1 still has issues with inmemory dbs
        // apparently its early doors scope from apple

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasMany(x => x.Orders).WithOne(y => y.Customer);

            modelBuilder.Entity<OrderItem>().HasOne(x => x.Order).WithMany(y => y.OrderItems);

            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 1, Name = "Jacob" });

            modelBuilder.Entity<Order>().HasData(new Order { Id = 1, CustomerId = 1, OrderDescription = "Big Order For Jacob", DateTime = new DateTime(2020, 07, 22) });

            modelBuilder.Entity<Entities.OrderItem>().HasData(new OrderItem { Id = 1, OrderId = 1, UnitPrice = 200, Quantity = 8, ItemName = "Wood" });

            modelBuilder.Entity<Entities.Order>().HasData(new Order { Id = 6, CustomerId = 1, OrderDescription = "Second Big Order For Jacob", DateTime = new DateTime(2020, 07, 22) });

            modelBuilder.Entity<OrderItem>().HasData(new OrderItem { Id = 6, OrderId = 6, UnitPrice = 43, Quantity = 100, ItemName = "Wood" });

            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 2, Name = "Aidan" });

            modelBuilder.Entity<Order>().HasData(new Order { Id = 2, CustomerId = 2, OrderDescription = "Big Order For Aidan", DateTime = new DateTime(2015,12,1) });

            modelBuilder.Entity<OrderItem>().HasData(new OrderItem { Id = 2, OrderId = 2, UnitPrice = 68, Quantity = 40, ItemName = "Steel" });

            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 3, Name = "Lexy" });

            modelBuilder.Entity<Order>().HasData(new Order { Id = 3, CustomerId = 3, OrderDescription = "Big Order For Lexy", DateTime = new DateTime(2022, 04, 15) });

            modelBuilder.Entity<OrderItem>().HasData(new OrderItem { Id = 3, OrderId = 3, UnitPrice = 7, Quantity = 32, ItemName = "Wool" });

            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 4, Name = "Maria" });

            modelBuilder.Entity<Order>().HasData(new Order { Id = 4, CustomerId = 4, OrderDescription = "Big Order For Mam", DateTime = new DateTime(2021, 04, 15) });

            modelBuilder.Entity<OrderItem>().HasData(new OrderItem { Id = 4, OrderId = 4, UnitPrice = 87, Quantity = 105, ItemName = "Wool" });

            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 5, Name = "Brian" });

            modelBuilder.Entity<Order>().HasData(new Order { Id = 5, CustomerId = 5, OrderDescription = "Big Order For Dad", DateTime = new DateTime(2021, 04, 15) });

            modelBuilder.Entity<OrderItem>().HasData(new OrderItem { Id = 5, OrderId = 5, UnitPrice = 112, Quantity = 61, ItemName = "Wool" });

            SaveChangesAsync();

        }

    }
}
