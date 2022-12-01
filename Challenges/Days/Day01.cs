using System.Linq;
using Challenges.Util;

namespace Challenges.Days
{
    public class Day01 : Day<int[][], int>
    {
        public override int Part1(int[][] puzzleInput)
        {
            return puzzleInput.Select(x => x.Sum()).Max();
        }

        public override int Part2(int[][] puzzleInput)
        {
            return puzzleInput.Select(x => x.Sum()).OrderByDescending(x => x).Take(3).Sum();
        }

        public override int[][] PreprocessData(string[] puzzleInput)
        {
            var result = new List<int[]>();
            var one = new List<int>();
            foreach (var s in puzzleInput)
            {
                if (s == "")
                {
                    result.Add(one.ToArray());
                    one = new List<int>();
                }
                else
                {
                    one.Add(int.Parse(s));
                }
            }
            result.Add(one.ToArray());

            return result.ToArray();
        }
    }
}
