using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgriTrack2.Models;

namespace AgriTrack2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FarmerData> Farmers { get; set; }
        public DbSet<EmployeeData> Employees { get; set; }
        public DbSet<CropData> Crops { get; set; }
        public DbSet<ExpenseData> Expenses { get; set; }
    }
}