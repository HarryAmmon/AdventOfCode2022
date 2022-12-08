using Solutions.Models;

namespace Solutions.Services
{
    public interface IRockPaperScissorsStrategyMachine
    {
        int CalculateScore(List<RockPaperScissorsRound> round);
    }
}