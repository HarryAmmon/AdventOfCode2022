using Solutions.Models;

namespace Solutions.Services
{
    public class CommunicationSystem
    {
        private readonly IFileSystem _fileSystem;
        private readonly IList<int> _values;

        public CommunicationSystem(IFileSystem fileSystem, IList<int> values)
        {
            _fileSystem = fileSystem;
            _values = values;
        }

        public FileType BuildFileTree(string[] commands)
        {
            FileType currentFile = new FileType() { Name = "/", Children = new List<FileType>() };

            foreach (var command in commands)
            {
                var parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (parts[0].Equals("$"))
                {
                    if (parts[1].Equals("cd"))
                    {
                        if (parts[2].Equals("/")) continue;
                        else if (parts[2].Equals(".."))
                        {
                            currentFile = currentFile.Parent;
                        }
                        else
                        {
                            currentFile = currentFile.Children.First(x => x.Name.Equals(parts[2]));
                        }
                    }
                }
                else if (parts[0].Equals("dir"))
                {
                    _fileSystem.CreateDirectory(currentFile, parts[1]);
                }
                else if (int.TryParse(parts[0], out var result))
                {
                    _fileSystem.CreateFile(currentFile, parts[1], result);
                }
            }

            return _fileSystem.GetRootDirectory(currentFile);
        }



        // Candidate for a file system service 
        public FileType CalculateDirectorySize(FileType dir)
        {
            var childDirectories = dir.Children.Where(x => !x.Size.HasValue && x.Type == DirectoryOrFile.Directory);
            if (!childDirectories.Any())
            {
                dir.Size = _fileSystem.GetDirectorySize(dir, 100000, _values);
                if (dir.Parent == null) return dir;
                CalculateDirectorySize(dir.Parent);
            }
            else
            {
                foreach (var child in childDirectories)
                {
                    CalculateDirectorySize(child);
                }
            }
            return dir;
        }

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