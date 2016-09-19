using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirdSightingTracker.Controllers;
using BirdSightingTracker.Models;
using BirdSightingTracker.Models.BSRepository;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Moq;
using static System.Diagnostics.TraceSource;


namespace BirdSightingTracker.Tests.ControllerTests
{
    public class SightingsControllerTest
    {

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            Mock<IBSRepository> mock = new Mock<IBSRepository>();
            mock.Setup(m => m.Sightings).Returns(new Sighting[]
            {
                new Sighting { Bird = new Bird { CommonName = "Portland Swift" }, ObserverFirstName = "Bob", ObserverLastName = "Smith", Place = new Place { City = "Portland" }, SightingDate = DateTime.Now, SightingId = 1 }

            }.ToList());//AsQueryable());
            var controller = new SightingsController(mock.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            Mock<IBSRepository> mock = new Mock<IBSRepository>();
            mock.Setup(m => m.Sightings).Returns(new Sighting[]
            {
                new Sighting { Bird = new Bird { CommonName = "Portland Swift" }, ObserverFirstName = "Bob", ObserverLastName = "Smith", Place = new Place { City = "Portland" }, SightingDate = DateTime.Now, SightingId = 1 }

            }.ToList());//AsQueryable());
            var controller = new SightingsController(mock.Object);
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<IEnumerable<Sighting>>(result);
        }

    }
}
