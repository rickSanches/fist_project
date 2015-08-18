using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tringle;
using System.Collections.Generic;



namespace testTriangle
{
    [TestClass]
    public class TestTrinangle
    {
        [TestMethod]
        public void IsNotValid() // test not valid triangel model
        {
            Random Rand = new Random();
            double newA = Rand.Next(0,0);
            double newB = Rand.Next(0, 100)*(-1);
            double newC = Rand.Next(0, 100)/100;
            var Mod = new Model { A = newA, B = newB, C =  newC };

            var tring = new Triangle();

            Assert.IsTrue(!tring.IsValid(Mod));
        }
        [TestMethod]
        public void TestIsValid() // test valid model tringle
        {
            Random Rand = new Random();
            double newA = 15;
            double newB = 15;
            double newC = 15;
            var Mod = new Model { A = newA, B = newB, C = newC };

            var tring = new Triangle();

            Assert.IsTrue(tring.IsValid(Mod));
        }
        [TestMethod]
        public void TestWorkigFormulGieron() // testing validation Gieron formula
        {
            //if we nave squaered angles triangle with catet A = 6, B = 8 and C = 10
            // squere equal is (A*B)/2 = 24
            
            double newA = 6;
            double newB = 8;
            double newC = 10;
            var Mod = new Model { A = newA, B = newB, C = newC };

            var tring = new Triangle();

            Assert.IsTrue(tring.Squre(Mod) == 24);
        }
    }
}
