using Microsoft.AspNetCore.Mvc;
using RestAPI_cw5.Database;

namespace RestAPI_cw5.Controllers;

[ApiController]
[Route("/animals-controller")]

public class AnimalController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDB().Animals;
        return Ok();
    }
    
    [HttpPost]
    public IActionResult AddAnimals()
    {
        return Created();
    }
}