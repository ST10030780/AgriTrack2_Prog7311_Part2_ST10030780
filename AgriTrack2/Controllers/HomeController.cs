using System.Diagnostics;
using AgriTrack2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

namespace AgriTrack2.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Dashboard()
        {
            var userRole = User.FindFirst("Role")?.Value;

            if (userRole == "Farmer") return View("FarmerDashboard");
            if (userRole == "Employee") return View("EmployeeDashboard");

            return View("GeneralDashboard");
        }
    }
}



   