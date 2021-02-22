using System;

namespace ConsoleApplication
{
    class Program
    {
        static Random random = new Random();

        static char AsciiCharacter
        {
            get
            {
                int t = random.Next(10);
                if (t <= 2)
                    return (char)('1' + random.Next(10));
                else if (t <= 4)
                    return (char)('a' + random.Next(27));
                else if (t <= 6)
                    return (char)('B' + random.Next(27));
                else
                    return (char)(random.Next(32, 255));
            }
        }

        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.WriteLine("ENTER-ро зер кунед");
            Console.ReadKey();
            Console.CursorVisible = false;

            int WIDTH, HEIGHT;
            int[] y;

            Initialize(out WIDTH, out HEIGHT, out y);


            while (true)
                UpdateAllColumns(WIDTH, HEIGHT, y);
        }


        private static void UpdateAllColumns(int WIDTH, int HEIGHT, int[] y)
        {
            int x;

            for (x = 0; x < WIDTH; ++x)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x, y[x]);
                Console.Write(AsciiCharacter);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                int temp = y[x] - 2;
                Console.SetCursorPosition(x, inScreenYPosition(temp, HEIGHT));
                Console.Write(AsciiCharacter);

                int temp1 = y[x] - 20;
                Console.SetCursorPosition(x, inScreenYPosition(temp1, HEIGHT));
                Console.Write(' ');

                y[x] = inScreenYPosition(y[x] + 1, HEIGHT);
            }

            if (Console.KeyAvailable)
            {
                if (Console.ReadKey().Key == ConsoleKey.F5)
                    Initialize(out WIDTH, out HEIGHT, out y);
                if (Console.ReadKey().Key == ConsoleKey.F11)
                    System.Threading.Thread.Sleep(1);
            }

        }

        public static int inScreenYPosition(int yPosition, int HEIGHT)
        {
            if (yPosition < 0)
                return yPosition + HEIGHT;
            else if (yPosition < HEIGHT)
                return yPosition;
            else
                return 0;
        }

        private static void Initialize(out int WIDTH, out int HEIGHT, out int[] y)
        {
            HEIGHT = Console.WindowHeight;
            WIDTH = Console.WindowWidth - 1;

            y = new int[WIDTH];

            Console.Clear();
            for (int x = 0; x < WIDTH; ++x)
            {
                y[x] = random.Next(HEIGHT);
            }
        }
    }
}
