using System.ComponentModel.DataAnnotations;

namespace BirdSightingTracker.Models
{
    public class BirdColor
    {
        [Key]
        public int ColorId { get; set; }
        public string Name { get; set; }
    }
}