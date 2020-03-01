using NUnit.Framework;
using LinnworksTest.Models;
using System;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void PositiveCategoryModelUnitTest()
        {
            Category category = new Category();
            category.CategoryId = Guid.NewGuid();
            category.CategoryName = "Test Name";
            Assert.IsNotEmpty(category.CategoryId.ToString());
            Assert.AreEqual(category.CategoryName, "Test Name");
            Assert.Pass();
        }

        [Test]
        // This test will fail because there is no check on backend for empty name.
        // Name check made on the FrontEnd level but backend model successfully consume empty string.
        // Also this check doesn't exists in controller
        public void EmptyStringCategoryNameUnitTest() {
            Category category = new Category();
            category.CategoryId = Guid.NewGuid();
            category.CategoryName = "";
            Assert.IsNotEmpty(category.CategoryName);
        }
    }
}