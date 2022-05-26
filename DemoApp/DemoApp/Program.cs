using System;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cavidSalary = 1700;
            int resulSalary = 2000;
            int elminSalary = 2400;
            int ceyhunSalary = 1400;

            int totalSalary = cavidSalary + resulSalary + elminSalary + ceyhunSalary;

            int zekat = totalSalary / 25;
            Console.WriteLine(zekat);
            //Console.WriteLine("Hello World!");
        }
    }
}
