using Microsoft.EntityFrameworkCore;

namespace Code_Library_Console
{
    public class DataBaseContext : DbContext
    {
        public string connectionString = "host=localhost;port=5432;database=northwind;username=admin;password=admin";
        public DbSet<Customers> customers { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
        public DbSet<Shippers> shippers { get; set; }
        public DbSet<OrderDetails> order_details { get; set; }
        public DbSet<Region> regions { get; set; }
        public DbSet<Territories> territories { get; set; }
        public DbSet<EmployeeTerritories> employee_territories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }

    }
}
