﻿using System;
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
            int a, b, resultat;
            Console.WriteLine("Введите первое число:");
            a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            b= Convert.ToInt32(Console.ReadLine());
            resultat = a+b;
            Console.WriteLine("Результат: "+ resultat);
            Console.ReadKey();


        }
    }
}
