using System.Linq;
using Exercises;
using Xunit;

namespace ProgramTests
{
    public class ExerciseTests
    {
        [Fact]
        public void GetNumbersFromOneToTen()
        {
            var result = Program.GetNumbersFromOneToTen();

            Assert.True(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}.SequenceEqual(result));
        }

        [Theory]
        [InlineData("Vilius", "Zobela")]
        [InlineData("Milda", "Jakstaite")]
        public void GetFullName(string firstName, string lastName)
        {
            var result = Program.GetFullName(firstName, lastName);

            Assert.Equal($"{firstName} {lastName}", result);
        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(4, 5)]
        public void CalculatePerimeterOfSquare(int a, int b)
        {
            var result = Program.CalculatePerimeterOfSquare(a, b);
            var expected = (2 * a) + (2 * b);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4})]
        [InlineData(new[] {1, 7, 3, 4})]
        [InlineData(new[] {1, 7, 9, 4})]
        public void GetMaxNumber(int[] array)
        {
            var result = Program.GetMaxNumber(array);
            var expected = array.Max();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] {1, 2, 3, 4})]
        [InlineData(new[] {1, 7, 3, 4})]
        [InlineData(new[] {1, 7, 9, 4})]
        public void GetFirstAndLastSum(int[] array)
        {
            var result = Program.GetFirstAndLastSum(array);
            var expected = array.First() + array.Last();

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        [InlineData(new[] { 1, 7, 3, 4 }, new[] { 4, 3, 7, 1 })]
        [InlineData(new[] { 1, 7, 9, 4 }, new[] { 4, 9, 7, 1 })]
        public void ReverseArray(int[] array, int[] expected)
        {
            var actual = Program.ReverseArray(array);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("vilius")]
        [InlineData("milda")]
        [InlineData("ginte")]
        [InlineData("giNte")]
        public void StringToFirstUpperLetter(string someString)
        {
            var result = Program.StringToFirstUpperLetter(someString);

            var temp = someString.ToLower();
            var expected = $"{temp.First().ToString().ToUpper()}{temp.Substring(1)}";

            Assert.Equal(expected, result);
        }
    }
}