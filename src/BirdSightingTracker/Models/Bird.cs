using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSightingTracker.Models
{
    public class Bird
    {
        [Key]
        public int BirdId { get; set; }
        public string CommonName { get; set; }
        public string Family { get; set; }
        public string ScientificName { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public virtual ICollection<BirdColor> TertiaryColors { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }
        public string Size { get; set; }
        public virtual ICollection<Sighting> Sightings { get; set; }
        public virtual ICollection<Place> Habitats { get; set; }
        public string ConservationStatus { get; set; }
        public string ConservationCode { get; set; }
        
    }
}
