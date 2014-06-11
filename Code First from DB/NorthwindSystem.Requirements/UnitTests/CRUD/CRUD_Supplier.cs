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
        
        [Fact]
        [AutoRollback]
        public void Should_Update()
        {
            // Arrange
            // Act
            // Assert
            throw new NotImplementedException();
        }

        [Fact]
        [AutoRollback]
        public void Should_Delete()
        {
            // Arrange
            // Act
            // Assert
            throw new NotImplementedException();
        }
    }
}
