using AdventOfCodeCore;
using Solutions.Services;

namespace Solutions
{
    public class Day7 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var fileSystem = new FileSystem();
            var values = new List<int>();
            var system = new CommunicationSystem(fileSystem, values);
            var fileTree = system.BuildFileTree(fileContent);
            system.CalculateDirectorySize(fileTree);

            return values.Sum();
        }

        public int Part2(string[] fileContent)
        {
            throw new NotImplementedException();
        }
    }
}