namespace DiamondKata.Tests
{
    [TestFixture]
    public class DiamondKataTests
    {
        public Diamond _sut;

        [Test]
        public void Should_ShowOneLetterAOnly_WhenLetterIsA()
        {
            // Arrange
            _sut = new Diamond('A');

            // Act
            _sut.Print();

            // Assert
            Assert.That(_sut._printableOutput.ToString(), Is.EqualTo("A"));
        }
    }
}