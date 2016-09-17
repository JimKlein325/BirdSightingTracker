using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BirdSightingTracker.Models;
using Xunit;

namespace BirdSightingTracker.Tests
{
    public class BirdTest
    {
        [Fact]
        public void GetCommonNameTest()
        {
            //Arrange
            var bird = new Bird();

            //Act
            bird.CommonName = "Crow";
            var result = bird.CommonName;

            //Assert
            Assert.Equal("Crow", result);
        }
    }
   
}
