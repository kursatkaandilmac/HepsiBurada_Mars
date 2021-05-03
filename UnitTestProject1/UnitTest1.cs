using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HepsiBurada_Mars_Control;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestScanrio_12N_LMLMLMLMM() 
        {
            HepsiBurada_Mars_Control.HepsiBurada_Mars_Control HepsiBurada_Mars_Control = new HepsiBurada_Mars_Control.HepsiBurada_Mars_Control()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "LMLMLMLMM";

            HepsiBurada_Mars_Control.StartMoving(maxPoints, moves);

            var actualOutput = $"{HepsiBurada_Mars_Control.X} {HepsiBurada_Mars_Control.Y} {HepsiBurada_Mars_Control.Direction.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod]
        public void TestScanrio_33E_MRRMMRMRRM()
        {
            HepsiBurada_Mars_Control.HepsiBurada_Mars_Control HepsiBurada_Mars_Control = new HepsiBurada_Mars_Control.HepsiBurada_Mars_Control()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxPoints = new List<int>() { 5, 5 };
            var moves = "MRRMMRMRRM";

            HepsiBurada_Mars_Control.StartMoving(maxPoints, moves);

            var actualOutput = $"{HepsiBurada_Mars_Control.X} {HepsiBurada_Mars_Control.Y} {HepsiBurada_Mars_Control.Direction.ToString()}";
            var expectedOutput = "2 3 S";

            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
