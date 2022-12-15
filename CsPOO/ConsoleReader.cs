namespace CsPOO
{
    internal class ConsoleReader : IReadable
    {
        public string Read()
        {
            return Console.ReadLine() ?? "";
        }
    }
}
