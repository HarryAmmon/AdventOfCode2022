using Solutions.Models;

namespace Solutions.Services
{
    public class RockPaperScissorsStrategyMachine : IRockPaperScissorsStrategyMachine
    {
        public int CalculateScore(string[] strategyGuide)
        {
            List<RockPaperScissorsRound> rounds = new List<RockPaperScissorsRound>();
            foreach (var strategy in strategyGuide)
            {
                RockPaperScissorsRound round = new(strategy[0], strategy[2]);

                if (CalculateWinner(round).Equals("me"))
                {
                    round.Score = 6 + round.MyHand switch
                    {
                        'R' => 1,
                        'P' => 2,
                        'S' => 3,
                        _ => 0
                    };
                }
                else if (CalculateWinner(round).Equals("draw"))
                {
                    round.Score = 3 + round.MyHand switch
                    {
                        'R' => 1,
                        'P' => 2,
                        'S' => 3,
                        _ => 0
                    };
                }
                else if (CalculateWinner(round).Equals("opponent"))
                {
                    round.Score = round.MyHand switch
                    {
                        'R' => 1,
                        'P' => 2,
                        'S' => 3,
                        _ => 0
                    };
                }
                rounds.Add(round);
            }

            var score = 0;
            foreach (var round in rounds)
            {
                score = round.Score + score;
            }
            return score;
        }

        public string CalculateWinner(RockPaperScissorsRound round)
        {
            if (round.OpponentsHand == 'R' && round.MyHand == 'S' || round.OpponentsHand == 'P' && round.MyHand == 'R' || round.OpponentsHand == 'S' && round.MyHand == 'P')
            {
                return "opponent";
            }
            else if (round.OpponentsHand == 'S' && round.MyHand == 'R' || round.OpponentsHand == 'R' && round.MyHand == 'P' || round.OpponentsHand == 'P' && round.MyHand == 'S')
            {
                return "me";
            }
            else
            {
                return "draw";
            }
        }
    }
}