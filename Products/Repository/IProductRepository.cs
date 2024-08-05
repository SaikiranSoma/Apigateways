using Products.Models;

namespace Products.Repository
{
    public interface IProductRepository
    {

            public IEnumerable<Product> GetAllProducts();

           public Product GetProductById(Guid id);
            public bool AddProduct(Product product);


            public bool DeleteProduct(Guid Id);

            public bool UpdateProduct(Guid Id,Product product);
    }
}
