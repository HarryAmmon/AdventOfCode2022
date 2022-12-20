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

        public CrateDepot MoveCrates9000(IEnumerable<CraneInstruction> craneInstructions)
        {
            foreach (var instruction in craneInstructions)
            {
                for (int i = 0; i < instruction.Quantity; i++)
                {
                    if (_depot.CrateRow[instruction.From - 1].TryPop(out var result))
                    {
                        _depot.CrateRow[instruction.To - 1].Push(result);
                    }
                }
            }
            return _depot;
        }

        public CrateDepot MoveCrates9001(IEnumerable<CraneInstruction> craneInstructions)
        {
            foreach (var instruction in craneInstructions)
            {
                var grabber = new char[instruction.Quantity];
                for (int i = 0; i < instruction.Quantity; i++)
                {
                    if (_depot.CrateRow[instruction.From - 1].TryPop(out var result))
                    {
                        grabber[i] = result;
                    }
                }
                for (int i = instruction.Quantity - 1; i >= 0; i--)
                {
                    _depot.CrateRow[instruction.To - 1].Push(grabber[i]);
                }
            }
            return _depot;
        }
    }
}