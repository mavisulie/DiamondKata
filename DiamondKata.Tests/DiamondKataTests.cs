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
            Assert.That(_sut._printableOutput.ToString().Trim(), Is.EqualTo("A"));
        }

        [TestCase('B', " A \nB B\n A \n")]
        [TestCase('C', "  A  \n B B \nC   C\n B B \n  A  \n")]
        [TestCase('D', "   A   \n  B B  \n C   C \nD     D\n C   C \n  B B  \n   A   \n")]
        public void Should_ShowCorrectOutputBasedOnGivenLetter(char letter, string desiredOutput)
        {
            // Arrange
            _sut = new Diamond(letter);

            // Act
            _sut.Print();

            // Assert
            Assert.That(_sut._printableOutput.ToString(), Is.EqualTo(desiredOutput));
        }
    }
}