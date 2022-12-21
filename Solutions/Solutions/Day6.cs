using AdventOfCodeCore;

namespace Solutions
{
    public class Day6 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var dataStream = fileContent[0].ToCharArray();
            for (int i = 3; i < dataStream.Length; i++)
            {
                var current4bits = new char[] { dataStream[i - 3], dataStream[i - 2], dataStream[i - 1], dataStream[i] };
                if (current4bits.Distinct().Count() == current4bits.Length)
                {
                    return i + 1;
                }
            }
            return 0;
        }

        public int Part2(string[] fileContent)
        {
            throw new NotImplementedException();
        }
    }
}