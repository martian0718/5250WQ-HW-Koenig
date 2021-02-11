﻿using System;
using Mine.Models;
using NUnit.Framework;
using Mine.Helpers;

namespace UnitTests.Helpers
{
    [TestFixture]
    public class DiceHelperUnitTest
    {
        [Test]
        public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
        {
            // Arrange
            // Act
            var result = DiceHelper.RollDice(0, 1);
            //reset
            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
