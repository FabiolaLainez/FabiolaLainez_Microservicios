using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("orders")]
public class OrderController : ControllerBase
{
    private static List<string> orders = new() { "Order1", "Order2", "Order3" };

    [HttpGet]
    public IActionResult GetAll() => Ok(orders);

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        if (id < 0 || id >= orders.Count) return NotFound();
        return Ok(orders[id]);
    }
}