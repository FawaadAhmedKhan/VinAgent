using VinAgentAPI.Services;

namespace VinAgent.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_Should_Return_Correct_Result()
        {
            // Arrange
            var calculator = new CalculatorService();

            // Act
            var result = calculator.Add(10, 20);

            // Assert
            Assert.Equal(30, result);
        }
    }
}