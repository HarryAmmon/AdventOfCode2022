using AdventOfCodeCore;
using Solutions.Models;
using Solutions.Services;

namespace Solutions
{
    public class Day2 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var machine = new RockPaperScissorsStrategyMachine();
            List<RockPaperScissorsRound> rounds = new List<RockPaperScissorsRound>();
            foreach (var strategy in fileContent)
            {
                var round = RockPaperScissorsRound.CreateWithoutTrust(strategy[0], strategy[2]);
                rounds.Add(round);
            }
            return machine.CalculateScore(rounds);
        }

        public int Part2(string[] fileContent)
        {
            var machine = new RockPaperScissorsStrategyMachine();
            List<RockPaperScissorsRound> rounds = new List<RockPaperScissorsRound>();
            foreach (var strategy in fileContent)
            {
                rounds.Add(RockPaperScissorsRound.CreateWithTrust(strategy[0], strategy[2]));
            }
            return machine.CalculateScore(rounds);
        }
    }
}