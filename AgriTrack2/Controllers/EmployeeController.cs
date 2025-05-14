using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AgriTrack2.Data;
using AgriTrack2.Models;

namespace AgriTrack2.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var employees = await _context.Employees.ToListAsync();
            return View(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmployeeData employee)
        {
            if (!ModelState.IsValid) return View(employee);

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}