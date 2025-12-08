namespace Day08.Tests
{
    public class BoxMapTests
    {
        private BoxMap _boxMap;
        public BoxMapTests()
        {
            string filename = "Day08TestInput.txt";
            FileReader fileReader = new();
            IEnumerable<JunctionBox> boxes = fileReader.GetJunctionBoxes(filename);
            _boxMap = new();
            _boxMap.Add(boxes);
        }

        [Fact]
        public void CircuitsCount_IsInitially20()
        {
            // Assert
            Assert.Equal(20, _boxMap.Circuits.Count());
        }

        [Fact]
        public void Distances_ContainsFirstTwoBoxes()
        {
            // Arrange
            JunctionBox boxA = new(162, 817, 812);
            JunctionBox boxB = new(57, 618, 57);

            // Assert
            Assert.Single(_boxMap.BoxDistances.Where(bd => bd.JunctionBoxPair.Contains(boxA) && bd.JunctionBoxPair.Contains(boxB)));
        }

        [Fact]
        public void ShortestDistance_ContainsExpectedJunctionBoxes()
        {
            // Arrange
            JunctionBox boxA = new(162, 817, 812);
            JunctionBox boxB = new(425, 690, 689);

            // Act
            BoxDistance shortestDistance = _boxMap.GetShortestUnconnectedDistance();

            // Assert
            Assert.True(shortestDistance.JunctionBoxPair.Contains(boxA));
            Assert.True(shortestDistance.JunctionBoxPair.Contains(boxB));
        }

        [Fact]
        public void CircuitCounts_Is19_AfterConnectingOnce()
        {
            // Act
            _boxMap.ConnectShortestUnconnected();

            // Assert
            Assert.Equal(19, _boxMap.Circuits.Count());
        }

        [Fact]
        public void CircuitCounts_Is18_AfterConnectingTwice()
        {
            // Act
            _boxMap.ConnectShortestUnconnected();
            _boxMap.ConnectShortestUnconnected();

            // Assert
            Assert.Equal(18, _boxMap.Circuits.Count());
        }

        [Fact]
        public void LargestCircuitCount_Is2_AfterConnectingOnce()
        {
            // Act
            _boxMap.ConnectShortestUnconnected();

            // Assert
            Assert.Equal(2, _boxMap.OrderedCircuits().First().JunctionBoxes.Count);
        }

        [Fact]
        public void LargestCircuitCount_Is3_AfterConnectingTwice()
        {
            // Act
            _boxMap.ConnectShortestUnconnected();
            _boxMap.ConnectShortestUnconnected();

            // Assert
            Assert.Equal(3, _boxMap.OrderedCircuits().First().JunctionBoxes.Count);
        }

        [Fact]
        public void LargestCircuitCount_Is5_AfterConnectingTenTimes()
        {
            // Act
            for (int i = 0; i < 10; i++)
                _boxMap.ConnectShortestUnconnected();

            // Assert
            Assert.Equal(5, _boxMap.OrderedCircuits().First().JunctionBoxes.Count);
        }

        [Fact]
        public void ProductOfLargestThreeCircuits_Is40_AfterTenConnections()
        {
            // Arrange
            for (int i = 0; i < 10; i++)
                _boxMap.ConnectShortestUnconnected();
            IEnumerable<Circuit> circuits = _boxMap.OrderedCircuits();
            int product = 1;

            // Act
            for (int i = 0; i < 3; i++)
                product *= circuits.ElementAt(i).JunctionBoxes.Count;


            // Assert
            Assert.Equal(40, product);
        }
    }
}
