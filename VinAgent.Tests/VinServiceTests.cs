using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VinAgentAPI.Repositories;
using VinAgentAPI.Services;

namespace VinAgent.Tests
{
    public class VinServiceTests
    {
        [Fact]
        public void GetVehicle_Should_Return_Vehicle_Details()
        {

            // Arrange
            var mockRepository = new Mock<IVinRepository>();

            mockRepository
                .Setup(x => x.GetVehicleByVin("ABC123"))
                .Returns("BMW X5");


            var service = new VinService(mockRepository.Object);


            // Act
            var result = service.GetVehicle("ABC123");


            // Assert
            Assert.Equal("BMW X5", result);

        }
    }
}
