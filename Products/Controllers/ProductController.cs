using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Products.Models;
using Products.Repository;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository) {
            _productRepository = productRepository;

        }
        [HttpGet]
        public IActionResult GetProduct()
        {
            var result = _productRepository.GetAllProducts();

            return Ok(result);
        }


        [HttpGet("{id}")]

        public IActionResult GetProductById(Guid id) {

            var result = _productRepository.GetProductById(id);

            return Ok(result);

        }
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product) {

            _productRepository.AddProduct(product);
            return Ok("Product Added Succesfully");

        }


        [HttpDelete("{id}")]

        public IActionResult DeleteProductById(Guid id)
        {
            var result=_productRepository.DeleteProduct(id);

            if (result != null)
            {
                return Ok($"Product {id}is deleted ");

            }

            return NotFound($"Product {id } not found");
        }


        [HttpPut("{id}")]

        public IActionResult UpdateProduct(Guid id, [FromBody] Product product)
        {
            var products = _productRepository.UpdateProduct(id, product);

            if (product != null)
            {
                return Ok($"Product with {id} updated succesfuly");
            }
            return NotFound("Product not found");
        }

    }
}
