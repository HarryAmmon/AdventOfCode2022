using Solutions.Models;

namespace Solutions.Services
{
    public class GiantCargoCrane
    {
        private CrateDepot _depot;
        public GiantCargoCrane(CrateDepot depot)
        {
            _depot = depot;
        }

        public CrateDepot MoveCrates(IEnumerable<CraneInstruction> craneInstructions)
        {
            foreach (var instruction in craneInstructions)
            {
                for (int i = 0; i < instruction.Quantity; i++)
                {
                    if (_depot.CrateRow[instruction.From - 1].TryPop(out var result))
                    {
                        _depot.CrateRow[instruction.To - 1].Push(result);
                    }
                    else
                    {
                        Console.WriteLine("Failed to pop");
                    }
                }
            }
            return _depot;
        }
    }
}