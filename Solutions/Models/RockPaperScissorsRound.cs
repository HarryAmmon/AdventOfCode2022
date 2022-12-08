namespace Solutions.Models
{
    public class RockPaperScissorsRound
    {
        public char OpponentsHand { get; set; }
        public char MyHand { get; set; }
        public int Score { get; set; }

        private RockPaperScissorsRound()
        {
        }

        public static RockPaperScissorsRound CreateWithoutTrust(char opponentsHand, char myHand)
        {
            var round = new RockPaperScissorsRound();
            round.OpponentsHand = Convert(opponentsHand);
            round.MyHand = Convert(myHand);
            return round;
        }

        public static RockPaperScissorsRound CreateWithTrust(char opponentsHand, char outcome)
        {
            var round = new RockPaperScissorsRound();
            round.OpponentsHand = Convert(opponentsHand);
            round.MyHand = CalculateMyHand(round.OpponentsHand, outcome);
            return round;
        }

        private static char Convert(char code)
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

        private static char CalculateMyHand(char opponentsHand, char outcome)
        {

            if (outcome == 'X')
            {
                return CalculateLoosingHand(opponentsHand);
            }
            else if (outcome == 'Z')
            {
                return CalculateWinningHand(opponentsHand);
            }
            else
            {
                return opponentsHand;
            }
        }

        private static char CalculateWinningHand(char opponentsHand)
        {
            if (opponentsHand == 'R')
            {
                return 'P';
            }
            else if (opponentsHand == 'P')
            {
                return 'S';
            }
            else
            {
                return 'R';
            }
        }

        private static char CalculateLoosingHand(char opponentsHand)
        {
            if (opponentsHand == 'R')
            {
                return 'S';
            }
            else if (opponentsHand == 'P')
            {
                return 'R';
            }
            else
            {
                return 'P';
            }
        }
        public override string ToString()
        {
            return $"{OpponentsHand}, {MyHand}";
        }
    }
}