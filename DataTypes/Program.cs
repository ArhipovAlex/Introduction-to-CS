using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
