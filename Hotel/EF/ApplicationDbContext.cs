using Hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Customer> customers { get; set; }
        public DbSet<OrderList> orderLists { get; set; }

        /// <summary>
        /// modelBuilder i use for create table name has my accordingly
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("customersTable");
            modelBuilder.Entity<OrderList>().ToTable("orderListsTable");

        }
    }
}
