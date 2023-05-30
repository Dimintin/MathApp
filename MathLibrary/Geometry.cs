using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class Geometry
    {
        //      Площадь равностороннего треугольника
        public static double SEqualTriangle(double a, double b, double h)
        {
            return ((a + b) / 2) * h;
        }

        //      Площадь прямоугольного треугольника
        public static double SStraightTriangle(double a, double h)
        {
            return a * h;
        }

        //      Площадь прямоугльника
        public static double SRectangle(double a, double b)
        {
            return a * b;
        }

        //      Площадь круга
        public static double SCircle(double r)
        {
            return 3.14 * r * r;
        }

        //      Площадь трапеции
        public static double STrapezoid(double a, double b)
        {
            return a * b / 2;
        }
    }
}
