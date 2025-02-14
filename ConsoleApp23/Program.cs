using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main()
        {
            Calculate obj1 = new Calculate();
            obj1.SetValues(4.0, 9.0);
            Console.WriteLine(obj1.GetInfo());
            Console.WriteLine("Корень " + obj1.CalculateSquareRootOfProduct());

            Calculate obj2 = new Calculate();
            obj2.SetValues(16.0, 25.0);
            Console.WriteLine(obj2.GetInfo());
            Console.WriteLine("Корень " + obj2.CalculateSquareRootOfProduct());

            Console.WriteLine("Введите два числа: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            double input2 = Convert.ToDouble(Console.ReadLine());

            Calculate obj3 = new Calculate(input1, input2);
            Console.WriteLine(obj3.GetInfo());
            Console.WriteLine("Корень: " + obj3.CalculateSquareRootOfProduct());
            Console.ReadKey();
        }
    }
}