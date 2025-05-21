using Microsoft.AspNetCore.Mvc;

namespace team1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Create([FromBody] object productDto)
        {
            return CreatedAtAction(nameof(GetById), new { id = 0 }, productDto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] object productDto)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
