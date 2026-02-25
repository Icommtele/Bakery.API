using Bakery.API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bakery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CakesController : ControllerBase
    {
        private readonly BakeryDbContext _context;

        public CakesController(BakeryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCakes(int? categoryId)
        {
            var query = _context.Cakes.AsQueryable();

            if (categoryId.HasValue)
                query = query.Where(c => c.CategoryId == categoryId);

            var cakes = await query.ToListAsync();

            return Ok(cakes);
        }
    }
}
