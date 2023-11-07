//#define CLASS_CONSOLE
//#define STRING_OPERATIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CLASS_CONSOLE
            Console.Title = "Introduction to .NET";
            Console.WriteLine("\t\t\t\t\tПривет .NET");
            Console.CursorLeft = 32;
            Console.CursorTop = 8;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.WriteLine("Cursore position");
            Console.ResetColor();

            Console.Beep(32676,1000);
#endif //CLASS_CONSOLE
#if STRING_OPERATIONS
            Console.Write("Введите ваше имя: ");
            string first_name=Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string last_name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(last_name+ " " + first_name+" "+age+"y/o");//конкатенация строк С++
            Console.WriteLine(String.Format("{0} {1} {2} y/o", last_name, first_name, age));//форматирование строк С
            Console.WriteLine($"{last_name} {first_name} {age} y/o");//интерполяция строк С#
#endif //STRING_OPERATIONS
        }
    }
}
