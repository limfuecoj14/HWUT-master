using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Set_Date_Should_Equal_1281996()
        {
            // Arrange
            var result = new ProductModel();
           
            // Act
            result.Date = new DateTime(1996, 1, 28);

            // Assert
            Assert.AreEqual("1/28/1996", result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Id);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Id = "321";

            // Assert
            Assert.AreEqual("321", result.Id);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Maker);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Maker = "321";

            // Assert
            Assert.AreEqual("321", result.Maker);
        }

        [TestMethod]
        public void ProductModel_Get_Image_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Image);
        }

        [TestMethod]
        public void ProductModel_Set_Image_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Image = "321";

            // Assert
            Assert.AreEqual("321", result.Image);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Url);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Url = "321";

            // Assert
            Assert.AreEqual("321", result.Url);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Title);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Title = "321";

            // Assert
            Assert.AreEqual("321", result.Title);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Description);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Description = "321";

            // Assert
            Assert.AreEqual("321", result.Description);
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(null, result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Sequence = "321";

            // Assert
            Assert.AreEqual("321", result.Sequence);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("Unknown", result.Email);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Email = "321";

            // Assert
            Assert.AreEqual("321", result.Email);
        }

        [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual("", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Should_Equal_321()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Logistics= "321";

            // Assert
            Assert.AreEqual("321", result.Logistics);
        }

        [TestMethod]
        public void ProductModel_Get_Ratings_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(5, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Set_Ratings_Should_Equal_1()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings[0] = 1;

            // Assert

            Assert.AreEqual(1, result.Ratings[0]);
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Should_Return_0()
        {
            // Arrange
            var result = new ProductModel();

            // Act
            result.Ratings = null;

            // Assert

            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Rating_Null_Ratings_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = null;

            // Act

            // Assert

            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Empty_Ratings_Count_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] { };

            // Act

            // Assert

            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Total_Zero_Ratings_Should_Equal_0()
        {
            // Arrange
            var result = new ProductModel();
            result.Ratings = new int[] {0,0};

            // Act

            // Assert

            Assert.AreEqual(0, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_Average_Default_Should_Equal_5()
        {
            // Arrange
            var result = new ProductModel();

            // Act

            // Assert

            Assert.AreEqual(5, result.AverageRating());
        }

        [TestMethod]
        public void ProductModel_ToString_Should_Equal_()
        {
            // Arrange
            var result = new ProductModel();
            string serial = JsonSerializer.Serialize<ProductModel>(result);

            // Act

            // Assert

            Assert.AreEqual(serial, result);
        }
    }
}
