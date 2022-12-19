using AdventOfCodeCore;

namespace Solutions
{
    public class Day4 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            int highest = 0;
            foreach (var line in fileContent)
            {
                var elfPairs = line.Split(',');
                var elfOneSections = elfPairs[0].Split('-');
                var elfTwoSections = elfPairs[1].Split('-');
                if (AssignementsFullyInAnother(elfOneSections, elfTwoSections))
                {
                    highest++;
                }
            }
            return highest;
        }

        public int Part2(string[] fileContent)
        {
            throw new NotImplementedException();
        }

        public bool AssignementsFullyInAnother(string[] elfOneSections, string[] elfTwoSections)
        {
            if (int.Parse(elfOneSections[0]) >= int.Parse(elfTwoSections[0]) && int.Parse(elfOneSections[1]) <= int.Parse(elfTwoSections[1]))
            {
                return true;
            }
            else if (int.Parse(elfOneSections[0]) <= int.Parse(elfTwoSections[0]) && int.Parse(elfOneSections[1]) >= int.Parse(elfTwoSections[1]))
            {
                return true;
            }
            return false;
        }
    }
}