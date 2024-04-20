using Infrastructure.Contexts;
using Infrastructure.Factories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ApiContext context) : ControllerBase
    {
        private readonly ApiContext _context = context;


        [HttpGet] public async Task<IActionResult> GetAllCategories() 
        {
            var categories = await _context.Categories.OrderBy(o => o.CategoryName).ToListAsync();
            return Ok(CategoryFactory.Create(categories));
        }
    }
}
