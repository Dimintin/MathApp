using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathLibrary;

namespace MathApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = new List<double>() { 7, 3, -9, 12, 1300};
            Console.WriteLine(Algebra.AvgInLine(list));
        }
    }
}
