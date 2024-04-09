using Microsoft.AspNetCore.Mvc;

namespace RestAPI_cw5.Controllers;

[ApiController]
[Route("/animals-controller")]

public class AnimalController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}