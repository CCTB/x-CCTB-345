using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
using Xunit;
using Xunit.Extensions;

namespace NorthwindSystem.Requirements.UnitTests.CRUD
{
    public class CRUD_Shipper
    {
        [Fact]
        [AutoRollback]
        public void Should_Add()
        {
            // Arrange
            var sut = new NorthwindManager();
            var expected = new Shipper()
            {
                CompanyName = "Montgomery Scott's Transporter Service",
                Phone = "780.555.1212"
            };

            // Act
            var actualId = sut.AddShipper(expected);

            // Assert
            Assert.True(actualId > 0);
            var actual = sut.GetShipper(actualId);
            Assert.Equal(expected.CompanyName, actual.CompanyName);
            Assert.Equal(expected.Phone, actual.Phone);
            Assert.Equal(actualId, actual.ShipperID);
        }

        private static IEnumerable<object[]> _CurrentShippers = null;
        public static IEnumerable<object[]> CurrentShippers
        {
            get
            {
                if (_CurrentShippers == null)
                {
                    var controller = new NorthwindManager();
                    var temp = new List<object[]>();
                    foreach (Shipper shipper in controller.ListShippers())
                    {
                        temp.Add(new object[] {shipper});
                    }
                    _CurrentShippers = temp;
                }
                return _CurrentShippers;
            }
        }

        [Theory]
        [PropertyData("CurrentShippers")]
        [AutoRollback]
        public void Should_Update(object existing)
        {
            // Arrange
            Shipper expected = existing as Shipper;
            var sut = new NorthwindManager();
            expected.Phone = "780.999.9999";

            // Act
            sut.UpdateShipper(expected);

            // Assert
            var actual = sut.GetShipper(expected.ShipperID);
            Assert.Equal(expected.CompanyName, actual.CompanyName);
            Assert.Equal(expected.Phone, actual.Phone);
            Assert.Equal(expected.ShipperID, actual.ShipperID);
        }

        [Theory]
        [PropertyData("CurrentShippers")]
        [AutoRollback]
        public void Should_Delete(object existing)
        {
            // TODO: x) Fix test - should only be able to delete a Shipper that is NOT being used - need to add, then delete
            // Arrange
            Shipper expected = existing as Shipper;
            var sut = new NorthwindManager();
            expected.Phone = "780.999.9999";

            // Act
            sut.DeleteShipper(expected);

            // Assert
            var actual = sut.GetShipper(expected.ShipperID);
            Assert.Equal(expected.CompanyName, actual.CompanyName);
            Assert.Equal(expected.Phone, actual.Phone);
            Assert.Equal(expected.ShipperID, actual.ShipperID);
        }
    }
}
