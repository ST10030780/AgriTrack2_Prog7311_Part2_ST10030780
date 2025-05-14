using System.ComponentModel.DataAnnotations;
namespace AgriTrack2.Models
{
    public class ExpenseData
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Amount { get; set; }

        public DateTime DateRecorded { get; set; }


    }
}
