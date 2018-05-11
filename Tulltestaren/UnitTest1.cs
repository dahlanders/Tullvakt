
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tulltestaren
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckWeightOfvehicle()
        {
            var test = TestaTullen.Program.CheckWeightOfvehicle(500);

            Assert.AreEqual(500,test);
        }

        [TestMethod]
        public void WhatDayIsIt()
        {
            var test = TestaTullen.Program.WhatDayIsIt("monday");

            Assert.AreEqual(true,test);
        }

        [TestMethod]
        public void WhatTypeOfVehicle()
        {
            var test = TestaTullen.Program.WhatTypeOfVehicle("motorbike", 1000);

            Assert.AreEqual(700,test);
        }
    }
}
