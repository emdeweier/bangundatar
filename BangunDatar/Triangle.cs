using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Triangle
    {
        public void Area(double bs, double height)
        {
            double result = (bs * height)/2;
            Console.WriteLine("Area : " + result);
        }
        public void Around(double side, double bs, double height)
        {
            double result = side + bs + height;
            Console.WriteLine("Around : " + result);
        }
    }
}
