namespace Solutions.Models
{
    public class RockPaperScissorsRound
    {
        public char OpponentsHand { get; set; }
        public char MyHand { get; set; }
        public int Score { get; set; }
        public RockPaperScissorsRound(char opponentsHand, char myHand)
        {
            OpponentsHand = ConvertStrategy(opponentsHand);
            MyHand = ConvertStrategy(myHand);
        }

        private char ConvertStrategy(char code)
        {
            if (code == 'A' || code == 'X')
            {
                return 'R';
            }
            else if (code == 'B' || code == 'Y')
            {
                return 'P';
            }
            else if (code == 'C' || code == 'Z')
            {
                return 'S';
            }
            return 'N';
        }
        public override string ToString()
        {
            return $"{OpponentsHand}, {MyHand}";
        }
    }
}