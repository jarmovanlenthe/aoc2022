using System.IO;
using Challenges.Days;
using Xunit;

namespace TestChallenges
{
    public class TestDay01
    {
        [Fact]
        public void TestPart1()
        {
            var day = new Day01();
            var input = day.PreprocessData(File.ReadAllLines("Input/01_1.txt"));
            Assert.Equal(24000, day.Part1(input));
        }

        [Fact]
        public void TestPart2()
        {
            var day = new Day01();
            var input = day.PreprocessData(File.ReadAllLines("Input/01_1.txt"));
            Assert.Equal(45000, day.Part2(input));
        }
    }
}
