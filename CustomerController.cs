using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("customers")]
public class CustomerController : ControllerBase
{
    private static List<string> customers = new() { "Juan", "Maria", "Carlos" };

    [HttpGet]
    public IActionResult GetAll() => Ok(customers);

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        if (id < 0 || id >= customers.Count) return NotFound();
        return Ok(customers[id]);
    }
}