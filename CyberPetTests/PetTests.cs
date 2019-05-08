using Microsoft.VisualStudio.TestTools.UnitTesting;
using CyberPet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberPet.Tests
{
    [TestClass()]
    public class PetTests
    {
        [TestMethod()]
        public void petHungerTest()
        {
            //Arrange
            var myPet = new Pet("Rover");
            var hungerIncrease = 20;
            myPet.Hunger = 70;
            var expected = myPet.Hunger + hungerIncrease;
            //Act
            myPet.petHunger(hungerIncrease);
            var actual = myPet.Hunger;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}