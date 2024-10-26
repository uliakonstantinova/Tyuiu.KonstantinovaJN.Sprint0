using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonstantinovaJN.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KonstantinovaJN.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("сумма элементов массива = " + DataService.AdditionArray(numArray));

            Console.WriteLine("разность элементов массива = " + DataService.SubtractionArray(numArray));

            Console.WriteLine("произведение элементов массива = " + DataService.MultiplicationArray(numArray));

            Console.ReadKey();
        }
    }
}
