using IMC.API.Controllers;
using IMC.API.Models;
using IMC.API.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace IMC.API.Test.UnitTest
{
    public class TaxJarControllerTests
    {
        [Fact]
        public async Task GetRateByLocation_WithUnexistingLocation_ReturnsNotFound()
        {
            //Arrange
            var serviceStub = new Mock<ITaxJarService>();
            serviceStub.Setup(service => service.GetTaxRates(It.IsAny<string>()))
                .ReturnsAsync((TaxRate)null);

            var controller = new TaxJarController(serviceStub.Object);

            //Act

            var result = await controller.GetRateByLocation(string.Empty);

            //Assert

            result.ToString().Equals(HttpStatusCode.NotFound);
        }

    }
}
