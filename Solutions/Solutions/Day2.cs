using AdventOfCodeCore;
using Solutions.Services;

namespace Solutions
{
    public class Day2 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var machine = new RockPaperScissorsStrategyMachine();
            return machine.CalculateScore(fileContent);
        }

        public int Part2(string[] fileContent)
        {
            throw new NotImplementedException();
        }
    }
}