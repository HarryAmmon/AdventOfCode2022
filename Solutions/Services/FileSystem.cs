using Solutions.Models;

namespace Solutions.Services
{
    public class FileSystem : IFileSystem
    {
        public FileType CreateDirectory(FileType parent, string name)
        {
            var dir = new FileType(parent, name, DirectoryOrFile.Directory);
            dir.Children = new();
            parent.Children.Add(dir);
            return dir;
        }

        public FileType CreateFile(FileType parent, string name, int size)
        {
            var file = new FileType(parent, name, DirectoryOrFile.File, size);
            parent.Children.Add(file);
            return file;
        }

        public int GetDirectorySize(FileType directory)
        {
            int size = 0;
            foreach (var child in directory.Children)
            {
                if (child.Size.HasValue)
                {
                    size += child.Size.Value;
                }
            }
            return size;
        }

        public int GetDirectorySize(FileType file, int maxDesiredSize, IList<int> values)
        {
            var size = GetDirectorySize(file);
            if (size <= maxDesiredSize)
            {
                values.Add(size);
            }
            return size;
        }

        public FileType GetRootDirectory(FileType fileTree)
        {
            while (fileTree.Parent != null && !fileTree.Name.Equals("/"))
            {
                fileTree = fileTree.Parent;
            }

            return fileTree;
        }
    }
}