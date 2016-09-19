using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace BirdSightingTracker.Models.BSRepository
{
    public interface IBSRepository
    {
        List<Sighting> Sightings { get; set; }
    }
}