using System.ComponentModel.DataAnnotations;
namespace AgriTrack2.Models
{
    public class EmployeeData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Position { get; set; }
    }
}
