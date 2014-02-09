﻿using NUnit.Framework;

namespace UnitsNet.Tests
{
    [TestFixture]
    public class InterUnitConversionTests
    {
        //private const double Delta = 1E-5;

        [Test]
        public void KilogramToKilogramForce()
        {
            var mass = Mass.FromKilograms(1);
            var force = Force.FromKilogramsForce(mass.Kilograms);
            Assert.AreEqual(mass.Kilograms, force.KilogramsForce);
        }

        [Test]
        public void KilogramForceToKilogram()
        {
            var force = Force.FromKilogramsForce(1);
            var mass = Mass.FromGravitationalForce(force);
            Assert.AreEqual(mass.Kilograms, force.KilogramsForce);
        } 
    }
}
