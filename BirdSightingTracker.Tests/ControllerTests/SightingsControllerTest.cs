using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirdSightingTracker.Controllers;
using BirdSightingTracker.Models;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace BirdSightingTracker.Tests.ControllerTests
{
    public class SightingsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            var controller = new SightingsController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
