using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonstantinovaJN.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //вызов метода сложения
            Console.WriteLine(DataService.Addition(1, 5));
            //вызов метода вычитания
            Console.WriteLine(DataService.Subtraction(15, 5));
            //вызов метода умножения
            Console.WriteLine(DataService.Multiplication(10, 10));
            //вызов метода деления
            Console.WriteLine(DataService.Division(5, 5));

            Console.ReadKey();
        }
    }
}
