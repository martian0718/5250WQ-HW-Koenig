﻿using System;
using Mine.Models;
using NUnit.Framework;
namespace UnitTests.Models
{
    [TestFixture]
    public class HomeMenuItemTests
    {
        [Test]
        public void HomeMenuItem_Constructor_Valid_()
        {
            //Arrange
            //Act
            //Reset
            //Assert
            Assert.Pass();
        }

        [Test]
        public void HomeMenuItem_Constructor_Valid_Default_Should_Pass()
        {
            //Arrange
            //Act
            var result = new HomeMenuItem();
            //Reset
            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void HomeManuItem_Set_Get_Valid_Default_Should_Pass()
        {
            // Arrange
            //Act
            var result = new HomeMenuItem();
            result.Title = "Title";
            result.Id = MenuItemType.About;

            //Reset

            //Assert
            Assert.AreEqual("Title", result.Title);
            Assert.AreEqual(MenuItemType.About, result.Id);
           

        }


    }
}
