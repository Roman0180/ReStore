using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// needed for db context
using Microsoft.EntityFrameworkCore; 
using API.Entities;
namespace API.Data
{
    // our store context class will extend from  the DbContext class and will inhereit many of its methods
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        // the table inside of our database will be called products
        public DbSet<Product> Products{get; set;}
    }
}