using System.Threading;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
        }

        public static void Count()
        {
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }
        }
    }
}