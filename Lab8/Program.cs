namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo d in drives)
            {
                Console.WriteLine("Название: {0}", d.Name);
                if (d.IsReady)
                {
                    Console.WriteLine("Объем диска: {0}", d.TotalSize);
                    Console.WriteLine("Свободно {0}", d.TotalFreeSpace);
                }
                Console.WriteLine();
            }
        }
    }
}
