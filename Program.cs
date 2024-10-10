using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, resultatsum,resultdiv,resymn,resmin;
            Console.WriteLine("Введите первое число:");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b= Convert.ToInt32(Console.ReadLine());



            resultatsum = a + b;
            Console.WriteLine("Результат суммы: " + resultatsum);
            Console.ReadKey();

            resmin = a - b;
            Console.WriteLine("Результат вычитания: " + resmin);
            Console.ReadKey();
            resymn = a * b;
            Console.WriteLine("Результат умножения: " + resymn);
            Console.ReadKey();
            resultdiv = a / b;
            Console.WriteLine("Результат деления: " + resultdiv);
            Console.ReadKey();

        }
    }
}
