using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllCoursesAsync()
    {
        return Ok();
    }

}
