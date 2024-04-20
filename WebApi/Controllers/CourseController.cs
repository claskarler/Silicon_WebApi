using Infrastructure.Contexts;
using Infrastructure.Factories;
using Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController(ApiContext context) : ControllerBase
{
    private readonly ApiContext _context = context;

    [HttpGet]
    public async Task<IActionResult> GetAllCourses()
    {
        var query = _context.Courses.Include(i => i.Category).AsQueryable();
        query = query.OrderByDescending(o => o.LastUpdated);

        var courses = await query.ToListAsync();

        var response = new CourseResultModel
        {
            Succeeded = true,
            Courses = CourseFactory.Create(courses),
        };
        return Ok(response);
        
        
    }

}
