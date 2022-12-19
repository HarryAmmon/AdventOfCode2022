using AdventOfCodeCore;
using Solutions.CollectionExtensions;
using Solutions.Constants;
using Solutions.Models;

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
            var totalPriority = 0;
            List<ElfGroup> elfGroups = new();
            for (int i = 0; i < fileContent.Length; i += 3)
            {
                elfGroups.Add(new ElfGroup
                {
                    BackPackOne = fileContent[i].ToCharArray(),
                    BackPackTwo = fileContent[i + 1].ToCharArray(),
                    BackPackThree = fileContent[i + 2].ToCharArray()
                });
            }
            foreach (var elfGroup in elfGroups)
            {
                var intersect = elfGroup.BackPackOne.Intersect(elfGroup.BackPackTwo);
                var duplicate = elfGroup.BackPackThree.Intersect(intersect).First();
                totalPriority += GetPriority(duplicate);
            }
            return totalPriority;
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
            var positionInAlphabet = Array.FindIndex(Alphabet.LatinAlphabet.ToCharArray(), x => x == duplicate);
            priority += positionInAlphabet + 1;
            return priority;
        }
    }
}