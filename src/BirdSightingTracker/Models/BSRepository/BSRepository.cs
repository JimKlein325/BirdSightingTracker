using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirdSightingTracker.Models;

namespace BirdSightingTracker.Models.BSRepository
{
    public class BSRepository: IBSRepository
    {
        private ApplicationDbContext _db;
        public IQueryable<Sighting> Sightings
        {
            get
            {
                return _db.Sightings;
            }
            set { }
        }

        public BSRepository(ApplicationDbContext context)
        {
            _db = context;
        }

 
        
    }
}
