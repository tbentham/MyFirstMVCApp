using System.Data.Entity;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.DAL
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base()
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}