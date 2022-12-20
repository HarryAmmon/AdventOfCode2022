using AdventOfCodeCore;
using Solutions.Factories;
using Solutions.Models;
using Solutions.Services;

namespace Solutions
{
    public class Day5 : ISolution<string>
    {
        public string Part1(string[] fileContent)
        {
            var depot = new CrateDepot(fileContent);

            var crane = new GiantCargoCrane(depot);
            List<CraneInstruction> instructions = new();
            for (int i = 10; i < fileContent.Length; i++)
            {
                instructions.Add(CraneInstructionFactory.Create(fileContent[i]));
            }
            var craneResult = crane.MoveCrates(instructions);
            var result = "";
            foreach (var stack in craneResult.CrateRow)
            {
                if (stack.TryPeek(out var peekResult))
                {
                    result = result + peekResult;
                }
            }
            return result;
        }

        public string Part2(string[] fileContent)
        {
            throw new NotImplementedException();
        }
    }
}