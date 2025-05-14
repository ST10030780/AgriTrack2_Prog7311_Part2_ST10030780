using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AgriTrack2.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        public string Role {  get; set; }   
    }
}
