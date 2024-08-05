using Products.Data;
using Products.Models;

namespace Products.Repository
{
    public class ProductRepository : IProductRepository
    {
        ProductDb _productDb;


        public ProductRepository(ProductDb productDb)
        {
            _productDb = productDb;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _productDb.products.ToList();
        }

        public Product GetProductById(Guid id)
        {
            var result = _productDb.products.FirstOrDefault(p => p.Id == id);

            return result;


        }

        public bool AddProduct(Product product)
        {
           if(product == null) return false;

            _productDb.products.Add(product);
            _productDb.SaveChanges();
            return true;

        }


        public bool DeleteProduct(Guid id)
        {
            var result = _productDb.products.FirstOrDefault(p => p.Id == id);
            _productDb.products.Remove((result));
            return true;
        }

        public bool UpdateProduct(Guid Id, Product product)
        {
            var result = _productDb.products.FirstOrDefault(p => p.Id == Id);

            if (result != null)
            {
                result.Name = product.Name;
                result.Price = product.Price;
                _productDb.SaveChanges();
                return true;
            }

            return false;

        }



    }


}

