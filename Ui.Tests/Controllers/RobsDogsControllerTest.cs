using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Web.Mvc;
using Ui.Controllers;

namespace Ui.Tests.Controllers
{
    [TestClass]
    public class RobsDogsControllerTest
    {
        const int mnEXPECTEDTOTALRECORDS = 3; // correct number of records expected.

        [TestMethod]
        public void Index()
        {
            // Arrange
            RobsDogsController controller = new RobsDogsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            // Should be testing/verifying call to GetAllDogOwners and subsequent methods down the stack.
            // Moq is installed to help you.

            // ====================================================================================================
            // Create test to ensure the expected 3/All records are returned. 
            // ----------------------------------------------------------------------------------------------------
            // Arrange
            var mockDogOwnerViewModelMapper = new Mock<Services.DogOwnerService>();

            // Act
            List<Entities.DogOwner> actual = mockDogOwnerViewModelMapper.Object.GetAllDogOwners();

            // getting records direct from entity
            Data.DogOwnerRepository expectedRepository = new Data.DogOwnerRepository();
            List<Entities.DogOwner> expectedRecords = expectedRepository.GetAllDogOwners();

            // Assert - Checking the expected results are not blank
            Assert.IsNotNull(expectedRecords);

            // Assert - Checking that results returned by service are not blank
            Assert.IsNotNull(actual);

            // Assert - Checking same amount of records in both data sets
            Assert.AreEqual(expectedRecords.Count, actual.Count);

            // Assert - Checking that correct number of records are returned
            Assert.AreEqual(actual.Count, mnEXPECTEDTOTALRECORDS);


        }
    }
}