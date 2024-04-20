﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SubscribeController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SubscribeAsync(string email)
    {
        return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> UnsubscribeAsync(string email)
    {
        return Ok();
    }
}
