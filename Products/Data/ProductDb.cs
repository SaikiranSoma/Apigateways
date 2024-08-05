using Microsoft.EntityFrameworkCore;
using Products.Models;
namespace Products.Data
{
    public class ProductDb:DbContext
    {

        public ProductDb(DbContextOptions<ProductDb> option) : base(option) { }


        public DbSet<Product> products {  get; set; }

    }
}
