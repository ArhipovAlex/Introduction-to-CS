using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            Console.WriteLine("Тестируйте управление WASD, Space и Enter. По завершению нажмите Escape.");
            do
            {
                input= Console.ReadKey(true);
                if (input.Key == ConsoleKey.W) Console.WriteLine("Вперед");
                if (input.Key == ConsoleKey.UpArrow) Console.WriteLine("Вперед");
                if (input.Key == ConsoleKey.A) Console.WriteLine("Влево");
                if (input.Key == ConsoleKey.LeftArrow) Console.WriteLine("Влево");
                if (input.Key == ConsoleKey.D) Console.WriteLine("Вправо");
                if (input.Key == ConsoleKey.RightArrow) Console.WriteLine("Вправо");
                if (input.Key == ConsoleKey.S) Console.WriteLine("Вниз");
                if (input.Key == ConsoleKey.DownArrow) Console.WriteLine("Вниз");
                if (input.Key == ConsoleKey.Spacebar) Console.WriteLine("Прыжок");
                if (input.Key == ConsoleKey.Enter) Console.WriteLine("Огонь");
            }
            while (input.Key != ConsoleKey.Escape);
        }
    }
}
