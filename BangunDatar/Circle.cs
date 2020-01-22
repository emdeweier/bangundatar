using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Circle
    {
        public void Area(double radius)
        {
            double result = 3.14 * Math.Pow(radius,2);
            Console.WriteLine("Area : " + result);
        }
        public void Around(double radius)
        {
            double result = 2 * 3.14 * radius;
            Console.WriteLine("Around : " + result);
        }
    }
}
