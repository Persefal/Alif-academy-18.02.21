using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Task task = new Task(Show);
            task.Start();

            Console.WriteLine("Завершение метода Main");
        }

        static void Show()
        {
            Console.WriteLine("Начало работы метода Show");

            Console.WriteLine("Завершение работы метода Show");
        }
    }
}
