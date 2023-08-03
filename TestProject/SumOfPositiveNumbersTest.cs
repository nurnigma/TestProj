using Microsoft.VisualStudio.TestPlatform.TestHost;
using TestConsoleApp;
namespace TestProject
{
    public class SumOfPositiveNumbersTest
    {
        [Fact]
        public void SumOfPositivesReturnsCorrectSum()
        {
            // Arrange
            int[] array = { 1, -4, 7, 12 };
            int expectedSum = 1+7+12;

            // Act
            int result = AmountPositiveNumbers.SumOfPositiveElements(array);

            // Assert
            Assert.Equal(expectedSum, result);
        }
    }
}