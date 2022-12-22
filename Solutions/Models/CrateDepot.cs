using Solutions.Constants;

namespace Solutions.Models
{
    public class CrateDepot
    {
        public List<Stack<char>> CrateRow;

        public CrateDepot(string[] fileContent)
        {
            var rowNumbers = fileContent[8].Split(' ', StringSplitOptions.RemoveEmptyEntries);
            CrateRow = new List<Stack<char>>();
            foreach (var number in rowNumbers)
            {
                CrateRow.Add(new Stack<char>());
            }
            int[] positionOfLetters = new int[] { 1, 5, 9, 13, 17, 21, 25, 29, 33 };
            for (int i = 7; i >= 0; i--)
            {
                var row = fileContent[i];
                for (int k = 0; k < positionOfLetters.Length; k++)
                {
                    if (Alphabet.LatinAlphabet.Contains(row[positionOfLetters[k]]))
                    {
                        CrateRow[k].Push(row[positionOfLetters[k]]);
                    }
                }

            }
        }
    }
}