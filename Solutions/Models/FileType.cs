namespace Solutions.Models
{
    public class FileType
    {
        public DirectoryOrFile Type { get; set; }
        public string Name { get; set; }
        public int? Size { get; set; }
        public FileType Parent { get; set; }
        public List<FileType> Children { get; set; }
        public FileType(FileType parent, string name, DirectoryOrFile type)
        {
            Parent = parent;
            Name = name;
            Type = type;
        }
        public FileType(FileType parent, string name, DirectoryOrFile type, int size) : this(parent, name, type)
        {
            Size = size;
        }
        public FileType() { }
    }
}