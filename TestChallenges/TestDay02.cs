using System.IO;
using Challenges.Days;
using Xunit;

namespace TestChallenges
{
    public class TestDay02
    {
        [Fact]
        public void TestPart1()
        {
            var day = new Day02();
            var input = day.PreprocessData(File.ReadAllLines("Input/02_1.txt"));
            Assert.Equal(15, day.Part1(input));
        }

        [Fact]
        public void TestPart2()
        {
            var day = new Day02();
            var input = day.PreprocessData(File.ReadAllLines("Input/02_1.txt"));
            Assert.Equal(12, day.Part2(input));
        }
    }
}
