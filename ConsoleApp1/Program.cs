namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs/egor.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Let's go");
                sw.WriteLine("Good game");
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
               
            }
            
        }
    }
}

        