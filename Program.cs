using System;

namespace Pow_max_min
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((Min(new double[] { -5050, -10, 0, 50, 100 })));

            Console.WriteLine((Max(new double[] { -9999999, 0, 50, 800 })));

            Console.WriteLine(MinMax(new double[] { -9999999, 0, 50, 800 }));

            Console.WriteLine((Pow(3)));

        }

        public static string MinMax(double[] x)
        {
            if (x.Length < 1)
            {
                return ("yue entered empty");

            }

            return $"Your maximum number is: {Max(x)}\nYour minimum number is: {Min(x)}";

        }

        public static double Pow(double x, double y = 2)
        {
            if (y == 0)
                return 1;

            double num = x;

            for (int i = 1; i < y; i++)
            {
                num = x * num;
            }

            return num;
        }

        public static double Max(double[] x)
        {
            if (x.Length < 1)
            {
                Console.WriteLine("yue entered empty");
                return double.NaN;
            }

            double max = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > max)
                    max = x[i];
            }

            return max;
        }

        public static double Min(double[] x)
        {
            if (x.Length < 1)
            {
                Console.WriteLine("yue entered empty");
                return double.NaN;
            }

            double min = x[0];

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < min)
                    min = x[i];
            }
            return min;
        }


    }


}

