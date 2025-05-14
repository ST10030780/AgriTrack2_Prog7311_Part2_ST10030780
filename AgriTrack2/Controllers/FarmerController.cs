using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using AgriTrack2.Data;
using AgriTrack2.Models;

namespace AgriTrack2.Controllers
{
    [Authorize(Roles = "Farmer")]
    public class FarmerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FarmerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchName)
        {
            var farmers = _context.Farmers.AsQueryable();

            if (!string.IsNullOrEmpty(searchName))
            {
                farmers = farmers.Where(f => f.Name.Contains(searchName));
            }

            return View(await farmers.ToListAsync());
        }
    }
}