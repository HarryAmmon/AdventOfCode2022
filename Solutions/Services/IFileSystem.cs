using Solutions.Models;

namespace Solutions.Services
{
    public interface IFileSystem
    {
        public FileType GetRootDirectory(FileType fileTree);
        public int GetDirectorySize(FileType file);
        public int GetDirectorySize(FileType file, int maxDesiredSize, IList<int> values);
        public FileType CreateFile(FileType parent, string name, int size);
        public FileType CreateDirectory(FileType parent, string name);
    }
}