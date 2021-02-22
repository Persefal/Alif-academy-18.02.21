using System;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task1 = new Task(() => Console.WriteLine("Процесс первый"));
            task1.Start();

            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Процесс второй"));

            Task task3 = Task.Run(() => Console.WriteLine("Процесс третий"));
        }
    }
}
