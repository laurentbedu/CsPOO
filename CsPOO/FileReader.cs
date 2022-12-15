namespace CsPOO
{
    internal class FileReader : IReadable
    {
        public string Filename { get; set; }
        public string Read()
        {
            return File.ReadAllText(Filename);
        }
    }
}
