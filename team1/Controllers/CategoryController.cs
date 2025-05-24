using Microsoft.AspNetCore.Mvc;

namespace team1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
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
        public IActionResult Create([FromBody] object categoryDto)
        {
            return CreatedAtAction(nameof(GetById), new { id = 0 }, categoryDto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] object categoryDto)
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
