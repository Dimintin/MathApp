using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public static class Trigonometry
    {

        //      Sin
        public static double SinA(double hypotenuse, double opposCathet) 
        {
            if (hypotenuse <= opposCathet)
            {
                Console.WriteLine("Error!");
                return double.NaN;
            }
            double result;
            result = opposCathet / hypotenuse;
            return result;
        }

        //      Cos
        public static double CosA(double hypotenuse, double adjCathet)
        {
            if (hypotenuse <= adjCathet)
            {
                Console.WriteLine("Error!");
                return double.NaN;
            }
            double result;
            result = adjCathet / hypotenuse;
            return result;
        }

        //      Tg
        public static double TgA(double adjCathet, double opposCathet)
        {
            double result;
            result = opposCathet / adjCathet;
            return result;
        }

        //      Ctg
        public static double CtgA(double adjCathet, double opposCathet)
        {
            double result;
            result = adjCathet / opposCathet;
            return result;
        }

        //      ArcSin
        public static double ArcSin()
        {
            //TODO
            return double.NaN;
        }
    }
}
