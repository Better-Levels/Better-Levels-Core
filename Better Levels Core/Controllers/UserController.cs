using Better_Levels_Core.Models;
using Better_Levels_Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Better_Levels_Core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        public UserController()
        {
        }

        [HttpGet]
        public ActionResult<List<User>> GetAll() => UserService.GetAll();

        [HttpGet("{id}")]
        public ActionResult<User> Get(long id)
        {
            User user = UserService.Get(id);

            if (user is null) return NotFound();
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            UserService.Add(user);

            return CreatedAtAction(nameof(Create), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, User user)
        {
            if (id != user.Id) return BadRequest();

            var existingUser = UserService.Get(id);
            if (existingUser is null) return NotFound();

            UserService.Update(user);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            User user = UserService.Get(id);

            if (user is null) return NotFound();

            UserService.Delete(id);

            return NoContent();
        }
    }
}
