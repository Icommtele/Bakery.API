using Azure.Core;
using Bakery.API.Data;
using Bakery.API.DTOs;
using Bakery.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private readonly BakeryDbContext _context;

        public OrdersController(BakeryDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderRequest request)
        {
            var cake = await _context.Cakes.FindAsync(request.CakeId);

            if (cake == null)
                return BadRequest("Invalid Cake");

            var order = new Order
            {
                CakeId = request.CakeId,
                Quantity = request.Quantity,
                ReadyTime = request.ReadyTime,
                TotalAmount = cake.Price * request.Quantity,
                OrderNumber = GenerateOrderNumber(),
                OrderDate = DateTime.Now,
                Status = "Pending"
            };

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return Ok(order);
        }

        private string GenerateOrderNumber()
        {
            return "BK" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
