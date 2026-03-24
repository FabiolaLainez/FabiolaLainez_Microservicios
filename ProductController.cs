using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("products")]
public class ProductController : ControllerBase
{
    private static List<string> products = new() { "Laptop", "Mouse", "Keyboard" };

    [HttpGet]
    public IActionResult GetAll() => Ok(products);

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        if (id < 0 || id >= products.Count) return NotFound();
        return Ok(products[id]);
    }
}