using System.ComponentModel.DataAnnotations;
namespace AgriTrack2.Models
{
    public class CropData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime PlantedDate { get; set; }
    }
}
