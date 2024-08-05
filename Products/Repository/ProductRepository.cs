using Products.Models;

namespace Products.Repository
{
    public class ProductRepository : IProductRepository
    {


        //private readonly IProductRepository _repository;


        private List<Product> _products = new List<Product>();

        //bool IProductRepository.AddProduct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       // bool IProductRepository.DeleteProduct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        //public ProductRepository(IProductRepository repository)
        //{
        //    _repository = repository;
        //}

        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(Guid id)
        {
            var result = _products.FirstOrDefault(p => p.Id == id);

            return result;


        }

        public bool AddProduct(Product product)
        {
           if(product == null) return false;

           _products.Add(product);
            return true;

        }


        public bool DeleteProduct(Guid id)
        {
            _products.Remove(GetProductById(id));
            if (_products != null)
            {
                return true;
            }
            return false;
        }

        //public Guid UpdateProduct(Guid Id,Product product)
        //{
        //    var result=_products.FirstOrDefault(product => product.Id == product.Id);

        //    if(result != null)
        //    {
        //        result.Name = product.Name;
        //        result.Price = product.Price;
              
        //    }

        //    return result.Id;

        //}



    }


}

