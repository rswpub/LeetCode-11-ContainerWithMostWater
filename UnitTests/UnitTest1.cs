using LeetCode_11_ContainerWithMostWater;

namespace UnitTests
{
    public class ProvideArrayOfIntegers
    {
        [Theory]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        public void ReturnsMaxArea(int[] heightArray, int expectedResult)
        {

            // Arrange

            // Act
            int actualResult = new Class1().MaxArea(heightArray);

            // Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Theory]
        [InlineData(new int[] { 1 })]
        [InlineData(new int[] { -1, 1 })]
        [InlineData(new int[] { 1, 10001 })]
        public void ThrowsConstraintViolationExceptionWhenConstraintsViolated(int[] heightArray)
        {

            // Arrange

            // Act
            Action action = () => new Class1().MaxArea(heightArray);

            // Assert
            Assert.Throws<ConstraintViolationException>(action);

        }

        [Fact]
        public void ThrowsConstraintViolationExceptionWhenArrayIsTooLarge()
        {

            // Arrange
            int[] heightArray = new int[100001];

            // Act
            Action action = () => new Class1().MaxArea(heightArray);

            // Assert
            Assert.Throws<ConstraintViolationException>(action);

        }
    }
}