using Microsoft.AspNetCore.Mvc;

namespace OrderService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {

        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public string Post(Order order)
        {
            return $"Order Created: Product Number: {order.ProductNumber} , Description: {order.Description}";
        }
    }

    public class Order
    {
        public int ProductNumber { get; set; }
        public string Description { get; set; }
    }
}