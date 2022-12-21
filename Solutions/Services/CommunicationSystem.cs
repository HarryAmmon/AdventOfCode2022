namespace Solutions.Services
{
    public class CommunicationSystem
    {
        public int GetStartOfPacketMarker(char[] dataStream)
        {
            return GetStartOfDataMarker(dataStream, 4);
        }

        public int GetStartOfMessageMarker(char[] dataStream)
        {
            return GetStartOfDataMarker(dataStream, 14);
        }

        public int GetStartOfDataMarker(char[] dataStream, int packetSize)
        {
            List<char> currentBits = new List<char>();
            for (int i = 0; i < packetSize; i++)
            {
                currentBits.Add(dataStream[i]);
            }
            for (int i = packetSize; i < dataStream.Length; i++)
            {
                if (currentBits.Distinct().Count() == packetSize)
                {
                    return i;
                }
                currentBits.RemoveAt(0);
                currentBits.Add(dataStream[i]);
            }
            return 0;
        }
    }
}