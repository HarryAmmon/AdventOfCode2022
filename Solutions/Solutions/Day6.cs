using AdventOfCodeCore;
using Solutions.Services;

namespace Solutions
{
    public class Day6 : ISolution<int>
    {
        public int Part1(string[] fileContent)
        {
            var dataStream = fileContent[0].ToCharArray();
            var system = new CommunicationSystem();
            return system.GetStartOfPacketMarker(dataStream);
        }

        public int Part2(string[] fileContent)
        {
            var dataStream = fileContent[0].ToCharArray();
            var system = new CommunicationSystem();
            return system.GetStartOfMessageMarker(dataStream);
        }
    }
}