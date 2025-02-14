using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Calculate
    {
        private double field1;
        private double field2;

        public Calculate()
        {
            field1 = 0;
            field2 = 0;
        }

        public Calculate(double value)
        {
            field1 = value;
            field2 = value;
        }

        public Calculate(double value1, double value2)
        {
            field1 = value1;
            field2 = value2;
        }

        public string GetInfo()
        {
            return $"Field1: {field1}, Field2: {field2}";
        }

        public double CalculateSquareRootOfProduct()
        {
            return Math.Sqrt(field1 * field2);
        }

        public void SetValues(double value1, double value2)
        {
            field1 = value1;
            field2 = value2;
        }
    }
}