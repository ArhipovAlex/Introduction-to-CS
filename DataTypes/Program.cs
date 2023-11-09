//#define CLASSWORK
//#define TASK_1
//#define TASK_2
//#define TASK_3
#define TASK_4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if CLASSWORK
            Console.WriteLine($"bool: {sizeof(bool)}, values: {true} or {false}");
            Console.WriteLine($"char: {sizeof(char)}");
            Console.WriteLine($"short занимает {sizeof(short)} Байт памяти, и принимает значения в диапазоне: {short.MinValue} ... {short.MaxValue}");
            Console.WriteLine($"ushort занимает {sizeof(ushort)} Байт памяти, и принимает значения в диапазоне: {ushort.MinValue} ... {ushort.MaxValue}");
            Console.WriteLine($"float занимает {sizeof(float)} Байт памяти, и принимает значения в диапазоне: {float.MinValue} ... {float.MaxValue}");
            Console.WriteLine($"double занимает {sizeof(double)} Байт памяти, и принимает значения в диапазоне: {double.MinValue} ... {double.MaxValue}");
            Console.WriteLine($"decimal занимает {sizeof(decimal)} Байт памяти, и принимает значения в диапазоне: {decimal.MinValue} ... {decimal.MaxValue}");
            Console.WriteLine('+'.GetType());
            Console.WriteLine(5.GetType());
            Console.WriteLine(5.5.GetType());
            Console.WriteLine(5.5f.GetType());
            Console.WriteLine(5.5m.GetType()); //m - money
#endif //ClassWork
#if TASK_1
            Console.Write("Введите дробное число: ");
            decimal number = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"{number} руб. = {Decimal.ToInt32(number)} руб. {Decimal.ToInt32(number*100)- Decimal.ToInt32(number)*100} коп.");
#endif //TASK_1
#if TASK_2
            Console.Write("Введите цену одной тетради: ");
            decimal price_notebook=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество купленных тетрадей: ");
            int count_notebook=Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену одного карандаша: ");
            decimal price_pencil=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество купленных карандашей: ");
            int count_pencil=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {(price_notebook*count_notebook)+(price_pencil*count_pencil)} руб.");
#endif //TASK_2
#if TASK_3
            Console.Write("Введите цену одной тетради: ");
            decimal price_notebook = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите цену одной обложки: ");
            decimal price_cover = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите количество комплектов: ");
            int count=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {(price_cover+price_notebook)*count} руб.");
#endif //TASK_3
#if TASK_4
            Console.Write("Введите расстояние до дачи в км: ");
            double distance=Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите расход бензина на 100 км: ");
            double consumption=Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену на 1 литр бензина в рублях: ");
            decimal price=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Поездка на дачу туда и обратно обойдется в {Decimal.Round(Convert.ToDecimal(distance/100*consumption)*price*2,2)} рублей");
#endif //TASK_4
        }
    }
}
