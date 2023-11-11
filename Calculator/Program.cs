using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите математическое выражение: ");
            string expression = "(11+(22+33)*4-5)/2 +3";// Console.ReadLine();
            //Console.WriteLine(Calculate(expression));
            Console.WriteLine(Explorer(expression));
        }
        private static string Explorer(string expression)
        {
            for(int i=0;i<expression.Length;i++)
            {
                if (expression[i]=='(')
                {
                    for (int j=i+1;j<expression.Length;j++)
                    {
                        if (expression[j] == '(')
                        {
                            string buffer = expression.Substring(j, expression.Length - j - 1);
                            Console.WriteLine(buffer);
                            Explorer(buffer);
                        }
                        if (expression[j]==')')
                        {
                            string buffer=expression.Substring(i+1,j-i-1);
                            return buffer;
                        }
                    }
                }
            }
            return null;
        }
        private static double Calculate(string expression)
        {
            expression = expression.Replace(".", ",");//замена символа в строке на другой символ
            //Console.WriteLine(expression);
            String[] numbers = expression.Split('+', '*', '/', '-');
            /*double a = Convert.ToDouble(numbers[0]);
            double b = Convert.ToDouble(numbers[1]);
            if (expression.Contains("+")) { Console.WriteLine($"{a}+{b}={a + b}"); }
            else if (expression.Contains("-")) { Console.WriteLine($"{a}-{b}={a - b}"); }
            else if (expression.Contains("*")) { Console.WriteLine($"{a}*{b}={a * b}"); }
            else if (expression.Contains("/")) { Console.WriteLine($"{a}/{b}={a / b}"); }*/
            String[] operations = expression.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ' ', ',');
            operations = operations.Where(val => val != "").ToArray();
            //foreach(String i in numbers) Console.Write(i +"\t"); Console.WriteLine();
            //foreach(String i in operations) Console.Write(i +"\t"); Console.WriteLine();
            double[] values = new double[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                values[i] = Convert.ToDouble(numbers[i]);
            }
            do
            {
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operations[i] == "*") values[i] *= values[i + 1];
                    if (operations[i] == "/") values[i] /= values[i + 1];
                    if (operations[i] == "*" || operations[i] == "/")
                    {
                        for (int j = i + 1; j < operations.Length; j++)
                        {
                            values[j] = values[j + 1];
                            operations[j - 1] = operations[j];
                        }
                        values[values.Length - 1] = 0;
                        operations[operations.Length - 1] = null;
                        i--;
                    }
                }
            } while(operations.Contains("*")||operations.Contains("/"));
            do 
            { 
                for (int i = 0; i < operations.Length; i++)
                {
                    if (operations[i] == "+") values[i] += values[i + 1];
                    if (operations[i] == "-") values[i] -= values[i + 1];
                    if (operations[i] == "+" || operations[i] == "-")
                    {
                        for (int j = i + 1; j < operations.Length; j++)
                        {
                            values[j] = values[j + 1];
                            operations[j - 1] = operations[j];
                        }
                        values[values.Length - 1] = 0;
                        operations[operations.Length - 1] = null;
                        i--;
                    }
                }
                if (operations[1] == null) operations[0] = null;
            } while (operations.Contains("+") || operations.Contains("-"));
            foreach (double i in values) Console.Write(i+"\t");
            Console.WriteLine();
            foreach (String i in operations) Console.Write(i + "\t");
            return values[0];
        }
    }
}
