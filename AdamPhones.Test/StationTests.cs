using AdamPhones.Core.Helpers;
using AdamPhones.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;

namespace AdamPhones.Test
{
    [TestClass]
    public class StationTests
    {
        private StringBuilder _sb;
        private List<string> _stationList;
        [TestInitialize]
        public void SetUp()
        {
            _sb = new StringBuilder();
            _stationList = Stations.GetStations();
        }

        [TestCleanup]
        public void CleanUp()
        {
            // Clean something that needs to be disposed/ cleaned / deleted from the Db..
        }
        [TestMethod]
        public void Program_SearchStation_Ok()
        {
            // Arrange
            char? charInput = 'e';
          
            // Act
            SearchHelper.InputChecks(ref charInput, ref _sb);
            
            var currentStations = SearchHelper.SearchForStation(_sb.ToString().ToLower(), _stationList);

            // Assert
            Assert.IsNotNull(currentStations);
            CollectionAssert.AreNotEqual(_stationList, currentStations);
            Assert.AreSame(currentStations[0], "Euston");
        }
        [TestMethod]
        public void Program_SearchStationNotFound_ReturnsEmpty()
        {
            // Arrange
            char? charInput = 'p';

            // Act
            SearchHelper.InputChecks(ref charInput, ref _sb);

            var currentStations = SearchHelper.SearchForStation(_sb.ToString().ToLower(), _stationList);

            // Assert
            CollectionAssert.AreNotEqual(_stationList, currentStations);
            Assert.AreEqual(currentStations.Count, 0);
        }
    }
}
