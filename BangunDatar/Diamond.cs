using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Diamond
    {
        public void Area(double d1, double d2)
        {
            double result = (d1 * d2) / 2;
            Console.WriteLine("Area : " + result);
        }
        public void Around(double side)
        {
            double result = 4 * side;
            Console.WriteLine("Around : " + result);
        }
    }
}
