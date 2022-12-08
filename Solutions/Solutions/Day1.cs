using AdventOfCodeCore;
using Solutions.Services;

namespace Solutions
{
    public class Day1 : ISolution<string>
    {
        public string Part1(string[] fileContent)
        {
            var calculator = new ElfCalorieCalculator();
            return calculator.MaximumCaloriesCarried(fileContent).ToString();
        }

        public string Part2(string[] fileContent)
        {
            var calculator = new ElfCalorieCalculator();
            return calculator.CaloriesCarriedByTopThreeElfs(fileContent).ToString();
        }
    }
}