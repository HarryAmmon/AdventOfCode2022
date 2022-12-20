namespace Solutions.Models
{
    public class CraneInstruction
    {
        public readonly int Quantity;
        public readonly int From;
        public readonly int To;

        public CraneInstruction(int quantity, int from, int to)
        {
            Quantity = quantity;
            From = from;
            To = to;
        }
    }
}