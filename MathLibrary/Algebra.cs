using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathLibrary
{
    public static class Algebra
    {
        //      Квадратное уравнение из листа
        public static double[] QuadEquation(List<int> list)
        {
            if (list.Count() != 3)
            {
                Console.WriteLine("Error!");
                return new double[0];
            }

            int D = list[1] * list[1] - 4 * list[0] * list[2];
            if (D < 0)
            {
                Console.WriteLine("No Roots");
                return new double[0];
            }
            else if (D == 0)
            {
                Console.WriteLine("One Root:");
                double[] x = new double[1];
                double x1 = -list[1] / 2 * list[0];
                x.Append(x1);
                return x;
            }
            else
            {
                Console.WriteLine("Two Roots:");
                double[] x = new double[2];
                double x1 = -list[1] + Math.Sqrt(D) / 2 * list[0];
                double x2 = -list[1] - Math.Sqrt(D) / 2 * list[0];
                x.Append(x1);
                x.Append(x2);
                return x;
            }
        }

        //      Квадратное уравнение из массива
        public static double[] QuadEquation(int[] array)
        {
            int D = array[1] * array[1] - 4 * array[0] * array[2];
            if (D < 0)
            {
                Console.WriteLine("No Roots");
                return new double[0];
            }
            else if (D == 0)
            {
                Console.WriteLine("One Root:");
                double[] x = new double[1];
                double x1 = -array[1] / 2 * array[0];
                x[0] = x1;
                return x;
            }
            else
            {
                Console.WriteLine("Two Roots:");
                double[] x = new double[2];
                double x1 = -array[1] + Math.Sqrt(D) / 2 * array[0];
                double x2 = -array[1] - Math.Sqrt(D) / 2 * array[0];
                x[0] = x1;
                x[1] = x2;
                return x;
            }
        }

        //      Линейное уравнение из листа
        public static double[] LinearEquation(int[] array)
        {
            return new double[0];
        }

        //      Сумма элементов массива
        public static double LineSum(double[] array)
        {
            double result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            return result;
        }

        //      Сумма элементов листа
        public static double LineSum(List<double> list)
        {
            double result = 0;
            foreach (var item in list)
            {
                result += item;
            }
            return result;
        }

        //      Наибольший элемент массива
        public static double MaxInLine(double[] array)
        {
            double result = array[0];
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (result < array[i + 1])
                {
                    result = array[i + 1];
                }
            }
            return result;
        }

        //      Наибольший элемент листа
        public static double MaxInLine(List<double> list)
        {
            double result = list[0];
            for (int i = 1; i < list.Count - 1; i++)
            {
                if (result < list[i + 1])
                {
                    result = list[i + 1];
                }
            }
            return result;
        }

        //      Среднее арифметическое массива
        public static double AvgInLine(double[] array)
        {
            return LineSum(array) / array.Length;
        }

        //      Среднее арифметическое листа
        public static double AvgInLine(List<double> list)
        {
            return LineSum(list) / list.Count;
        }

        public static string ToString(double[] a)
        {
            string result = "";
            foreach (var item in a)
            {
                result += Convert.ToString(item) + " ";
            }
            return result;
        }
    }
}
