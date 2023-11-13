using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    internal class Program
    {
            public static int x;//координаты игрока
            public static int y;
        static void Main(string[] args)
        {

            ConsoleKeyInfo input;
            start_game();//запускаем новую игру
            do
            {
                draw();//рисуем первый кадр или перерисовываем кадр с новыми координатами 
                input= Console.ReadKey(true);//перехватываем кнопку управления и меняем координаты объекта игрока
                if (input.Key == ConsoleKey.W) y--;
                if (input.Key == ConsoleKey.UpArrow) y--;
                if (input.Key == ConsoleKey.A) x--;
                if (input.Key == ConsoleKey.LeftArrow) x--;
                if (input.Key == ConsoleKey.D) x++;
                if (input.Key == ConsoleKey.RightArrow) x++;
                if (input.Key == ConsoleKey.S) y++;
                if (input.Key == ConsoleKey.DownArrow) y++;
            }
            while (input.Key != ConsoleKey.Escape);
            Console.Clear();
        }
        private static void draw()//рисуем или обновляем игровое поле чтобы отобразить изменения
        {
            Console.Clear();
            player_draw();
        }
        private static void start_game()//запускаем новую игру
        {
            Random rnd = new Random();
            x = rnd.Next(20,50);
            y = rnd.Next(20,50);
            draw();
        }
        private static void player_draw()//рисуем управляемый игроком объект
        {
            for (int j = 0; j < y; j++) Console.WriteLine();
            for (int i = 0; i < x; i++) Console.Write(" ");
            Console.Write("XXXXX");
            Console.WriteLine();
            for (int i = 0; i < x; i++) Console.Write(" ");
            Console.Write("XXXXX");
            Console.WriteLine();
            for (int i = 0; i < x; i++) Console.Write(" ");
            Console.Write("XXXXX");
        }
    }
}
