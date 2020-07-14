using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("something", false)]

        public void Test1(string word, bool expected)
        {
            //arrange
            var wordsmith = new WordSmith();

            //act
            var actual = wordsmith.IsAPalindrome(word);

            //assert

            Assert.Equal(expected, actual);
        }
    }
}
