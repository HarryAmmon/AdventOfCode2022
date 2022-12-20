using Solutions.Models;

namespace Solutions.Factories
{
    public class CraneInstructionFactory
    {
        public static CraneInstruction Create(string instruction)
        {
            var instructionAsArray = instruction.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return new CraneInstruction(int.Parse(instructionAsArray[1]),
            int.Parse(instructionAsArray[3]),
            int.Parse(instructionAsArray[5]));
        }
    }
}