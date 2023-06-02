using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManagerSystem.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using TaskManagerSystem.Data;

namespace TaskManagerSystem.Controllers
{
    [Authorize] // Requires authentication for all actions in this controller
    public class TaskController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Task
        public async Task<IActionResult> Index()
        {
            // Get tasks for the current authenticated user
            var tasks = await _context.Tasks
                .Where(t => t.UserId == User.Identity.Name)
                .ToListAsync();

            return View(tasks);
        }

        // GET: Task/Create
        public IActionResult Create()
    }
}
