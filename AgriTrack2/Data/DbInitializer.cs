using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using AgriTrack2.Models;
using AgriTrack2.Data;

namespace AgriTrack2.Data
{
    public static class DbInitializer
    {
        public static async Task Seed(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

            string[] roles = { "Admin", "Farmer", "Employee" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    var result = await roleManager.CreateAsync(new IdentityRole(role));
                    if (!result.Succeeded)
                    {
                        logger.LogError($"Failed to create role: {role}");
                    }
                }
            }

            // Ensure Admin user exists
            var existingAdmin = await userManager.FindByEmailAsync("admin@agritrack.com");
            if (existingAdmin == null)
            {
                var adminUser = new ApplicationUser
                {
                    UserName = "admin@agritrack.com",
                    Email = "admin@agritrack.com",
                    FullName = "System Administrator"
                };

                var result = await userManager.CreateAsync(adminUser, "Admin123!");
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(adminUser, "Admin");
                    logger.LogInformation("Admin user created successfully.");
                }
                else
                {
                    logger.LogError("Failed to create admin user.");
                }
            }
            else
            {
                logger.LogInformation("Admin user already exists.");
            }
        }
    }
}