using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Square
    {
        public void Area(double side)
        {
            double result = side * side;
            Console.WriteLine("Area : " + result);
        }
        public void Around(double side)
        {
            double result = 4 * side;
            Console.WriteLine("Around : " + result);
        }
    }
    class Rectangle : Square
    {
        public void Area(double length, double width)
        {
            double result = length * width;
            Console.WriteLine("Area : " + result);
        }
        public void Around(double length, double width)
        {
            double result = 2 * (length + width);
            Console.WriteLine("Around : " + result);
        }
    }
}
