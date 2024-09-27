using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UnicornTaskManager.Data;
using UnicornTaskManager.Models;

namespace UnicornTaskManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnicornTasksController : ControllerBase
    {
        private readonly UnicornDbContext _context;

        public UnicornTasksController(UnicornDbContext context)
        {
            _context = context;
        }

        // POST: api/UnicornTasks
        [HttpPost]
        public async Task<ActionResult<UnicornTask>> CreateTask(UnicornTask task)
        {
            _context.UnicornTasks.Add(task);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTask), new { id = task.TaskId }, task);
        }

        // GET: api/UnicornTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UnicornTask>>> GetTasks()
        {
            return await _context.UnicornTasks.ToListAsync();
        }

        // GET: api/UnicornTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UnicornTask>> GetTask(int id)
        {
            var task = await _context.UnicornTasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return task;
        }

        // PUT: api/UnicornTasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(int id, UnicornTask task)
        {
            if (id != task.TaskId)
            {
                return BadRequest();
            }

            _context.Entry(task).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/UnicornTasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            var task = await _context.UnicornTasks.FindAsync(id);
            if (task == null)
            {
                return NotFound();
            }

            _context.UnicornTasks.Remove(task);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
