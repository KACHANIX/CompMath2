using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMath2
{
    public static class Calculations
    {
        public static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        public static void Left_sided(ChosenFunction CF)
        {
            int steps = 100;

            const double THETA = 1f / 3;
            double step = (CF.HigherBorder - CF.LowerBorder) / steps;
            double error = CF.Precision;
            double integral_n;

            do
            {
                double x, result = 0;

                for (x = CF.LowerBorder; x <= CF.HigherBorder; x += step)
                    result += CF.Func(x) * (step);
                integral_n = result;
                

                result = 0;

                for (x = CF.LowerBorder; x <= CF.HigherBorder; x += step/2)
                    result += CF.Func(x) * (step/2);
                double integral_2n = result;
                
                error = THETA * Math.Abs(integral_2n - integral_n);

                //если нужная точность не достигнута, уменьшаем шаг в два раза
                if (error >= CF.Precision)
                {
                    step /= 2;
                }

            } while (error >= CF.Precision);
            Console.WriteLine($"{integral_n}, {(CF.HigherBorder - CF.LowerBorder) / step}, {error}");
        }
        public static void Right_sided(ChosenFunction CF)
        {
            int steps = 100;

            const double THETA = 1f / 3;
            double step = (CF.HigherBorder - CF.LowerBorder) / steps;
            double error = CF.Precision;
            double integral_n;

            do
            {
                double x, result = 0;

                for (x = CF.LowerBorder; x <= CF.HigherBorder; x += step)
                    result += CF.Func(x + step) * (step);
                integral_n = result;

                result = 0;

                for (x = CF.LowerBorder; x <= CF.HigherBorder; x += step / 2)
                    result += CF.Func(x + step / 2) * (step / 2);
                double integral_2n = result;

                error = THETA * Math.Abs(integral_2n - integral_n);

                //если нужная точность не достигнута, уменьшаем шаг в два раза
                if (error >= CF.Precision)
                {
                    step /= 2;
                }

            } while (error >= CF.Precision);
            Console.WriteLine($"{integral_n}, {(CF.HigherBorder - CF.LowerBorder) / step}, {error}");
        }
        public static void Midpoint(ChosenFunction CF)
        {
            int steps = 100;

            const double THETA = 1f / 3;
            double step = (CF.HigherBorder - CF.LowerBorder) / steps;
            double error = CF.Precision;
            double integral_n;

            do
            {
                double x, result = 0;

                for (x = CF.LowerBorder; x <= CF.HigherBorder; x += step)
                    result += CF.Func((x + x + step)/2) * (step);
                integral_n = result;

                result = 0;

                for (x = CF.LowerBorder; x <= CF.HigherBorder; x += step / 2)
                    result += CF.Func((x + x + step/2) / 2) * (step/2);
                double integral_2n = result;

                error = THETA * Math.Abs(integral_2n - integral_n);

                //если нужная точность не достигнута, уменьшаем шаг в два раза
                if (error >= CF.Precision)
                {
                    step /= 2;
                    Console.WriteLine("YEBOI");
                }
            } while (error >= CF.Precision);
            Console.WriteLine($"{integral_n}, {(CF.HigherBorder - CF.LowerBorder) / step}, {error}");

        }
        

    }
}
