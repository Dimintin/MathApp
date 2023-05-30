using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class Trigonometry
    {
        public static double SinA(double hypotenuse, double opposCathet) 
        {
            double result;
            result = opposCathet / hypotenuse;
            return result;
        }
        public static double CosA(double hypotenuse, double adjCathet)
        {
            double result;
            result = adjCathet / hypotenuse;
            return result;
        }
        public static double tgA(double adjCathet, double opposCathet)
        {
            double result;
            result = opposCathet / adjCathet;
            return result;
        }
        public static double ctgA(double adjCathet, double opposCathet)
        {
            double result;
            result = adjCathet / opposCathet;
            return result;
        }
    }
}
