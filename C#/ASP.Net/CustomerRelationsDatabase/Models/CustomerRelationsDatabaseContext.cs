using Microsoft.EntityFrameworkCore;
 
namespace CustomerRelationsDatabase.Models
{
    public class CustomerRelationsDatabaseContext : DbContext
    {
        public CustomerRelationsDatabaseContext(DbContextOptions options) : base(options) { }
 
        // for every model / entity that is going to be part of the db
        // the names of these properties will be the names of the tables in the db
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerCall> CustomerCalls { get; set; }
    }
}
