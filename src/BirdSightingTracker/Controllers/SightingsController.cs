using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BirdSightingTracker.Models;
using BirdSightingTracker.Models.BSRepository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BirdSightingTracker.Controllers
{
    public class SightingsController : Controller
    {
        private IBSRepository _repo;

        public SightingsController(IBSRepository repository)
        {
            _repo = repository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_repo.Sightings);
        }
    }
}
