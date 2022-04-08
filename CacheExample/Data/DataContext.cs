using CacheExample.Models;
using Microsoft.EntityFrameworkCore;

namespace CacheExample.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
