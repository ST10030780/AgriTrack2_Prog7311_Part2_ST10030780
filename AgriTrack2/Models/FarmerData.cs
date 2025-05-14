using System.ComponentModel.DataAnnotations;
namespace AgriTrack2.Models
{
    public class FarmerData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FarmLocation { get; set; }
    }
}
