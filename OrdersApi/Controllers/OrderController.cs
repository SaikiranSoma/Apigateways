using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrdersApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok("Your orders");
        }
    }
}
