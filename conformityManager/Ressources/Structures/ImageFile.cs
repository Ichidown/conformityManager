
namespace conformityManager.Ressources.Structures
{
    public struct ImageFile
    {
        public string name { get; set; } 
        public string extension { get; set; } 
        public byte[] data { get; set; }

        public ImageFile(string name, string extension, byte[] data) : this()
        {
            this.name = name;
            this.extension = extension;
            this.data = data;
        }
    }
}
