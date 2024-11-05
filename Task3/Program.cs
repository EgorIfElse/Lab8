namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/egor.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
