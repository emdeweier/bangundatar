using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Square, 2. Rectangle, 3. Circle, 4. Triangle, 5. Diamond, 6. Abstract Triangle");
            Console.Write("Choose Two-Dimentional Figure : ");
            int choose = Convert.ToInt16(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.Write("Input Side : ");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Square sObj = new Square();
                    sObj.Area(side);
                    sObj.Around(side);
                    break;
                case 2:
                    Console.Write("Input Length : ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Width : ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    Rectangle rObj = new Rectangle();
                    rObj.Area(length, width);
                    rObj.Around(length, width);
                    break;
                case 3:
                    Console.Write("Input Radius : ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle cObj = new Circle();
                    cObj.Area(radius);
                    cObj.Around(radius);
                    break;
                case 4:
                    Console.Write("Input Side : ");
                    side = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Base : ");
                    double bs = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Height : ");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Triangle tObj = new Triangle();
                    tObj.Area(bs, height);
                    tObj.Around(side, bs, height);
                    break;
                case 5:
                    Console.Write("Input Side : ");
                    side = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Diagonal 1 : ");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Input Diagonal 2 : ");
                    double d2 = Convert.ToDouble(Console.ReadLine());
                    Diamond dObj = new Diamond();
                    dObj.Area(d1, d2);
                    dObj.Around(side);
                    break;
                default:
                    break;
            }
        }
    }
}
