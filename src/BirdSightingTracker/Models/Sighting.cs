using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdSightingTracker.Models
{
    public class Sighting
    {
        [Key]
        public int SightingId { get; set; }
        public Bird Bird { get; set; }
        public DateTime SightingDate { get; set; }
        public string ObserverFirstName { get; set; }
        public string ObserverLastName { get; set; }
        public Place Place { get; set; }
    }
}
