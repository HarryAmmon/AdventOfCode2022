using AdventOfCodeCore;
using Solutions.CollectionExtensions;

namespace Solutions
{
    public class Day3 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var totalPriority = 0;
            foreach (string line in fileContent)
            {
                var charBackPack = line.ToCharArray();
                charBackPack.SplitMidpoint<char>(out var first, out var second);
                var duplicate = first.Intersect(second).First();
                totalPriority += GetPriority(duplicate);
            }

            return totalPriority;
        }

        public int Part2(string[] fileContent)
        {
            throw new NotImplementedException();
        }

        public int GetPriority(char duplicate)
        {
            int priority = 0;
            if (char.IsUpper(duplicate))
            {
                priority = 26;
            }
            else
            {
                duplicate = char.ToUpper(duplicate);
            }
            var positionInAlphabet = Array.FindIndex(Alphabet.LatinAlphabet, x => x == duplicate);
            priority += positionInAlphabet + 1;
            return priority;
        }
    }
}