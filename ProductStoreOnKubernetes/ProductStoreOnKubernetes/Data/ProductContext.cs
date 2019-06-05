using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductStoreOnKubernetes.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)

        {
            Database.EnsureCreated();
        }

        public DbSet<ProductStoreOnKubernetes.Models.Product> Product { get; set; }
    }
}
