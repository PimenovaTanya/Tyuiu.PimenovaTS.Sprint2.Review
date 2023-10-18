using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PimenovaTS.Sprint2.TaskReview.V12.Lib;

namespace Tyuiu.PimenovaTS.Sprint2.TaskReview.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            if (res)
            {
                Console.WriteLine("Точка находится взаштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится взаштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
