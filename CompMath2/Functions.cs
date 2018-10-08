using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMath2
{

    public delegate double Function(double x);
    public delegate void F(ChosenFunction CF);
    public struct ChosenFunction
    {
        public Function Func;
        public Func<double, double, bool> CheckIfIn;
        public double LowerBorder;
        public double HigherBorder;
        public double Precision;
        public F Action;

        public ChosenFunction(Function func, Func<double, double, bool> check, double First, double Second, double precision, int Choice)
        {
            Func = func;
            CheckIfIn = check;
            LowerBorder = First;
            HigherBorder = Second;
            Precision = precision;
            Action = Calculations.Left_sided;
            if (Choice == 2)
            {
                Action = Calculations.Right_sided;
            }
            if (Choice == 3)
            {
                Action = Calculations.Midpoint;
            }

        }
    }

    public class Functions
    {
        ChosenFunction CF;

        public bool Squarred()
        {
            Console.Clear();

            double First = 0, Second = 0, precision = 0;
            int Choice = 0;
            if (!Check.InputAndCheck(ref First, ref Second, ref precision, ref Choice))
            {
                Console.WriteLine("Higher bound is equal to the lower one");
                return true;
            }
            CF = new ChosenFunction(x => x * x, (a, b) => true, First, Second, precision, Choice);
            if (!CF.CheckIfIn(CF.LowerBorder, CF.HigherBorder))
            {
                Console.WriteLine("Function doesn't exist in this area");
                return true;
            }
            Console.WriteLine($"{CF.LowerBorder}  {CF.HigherBorder}, {CF.Func(5)}");
            CF.Action(CF);
            return true;

        }
        public bool Sin()
        {
            Console.Clear();

            double First = 0, Second = 0, precision = 0;
            int Choice = 0;
            if (!Check.InputAndCheck(ref First, ref Second, ref precision, ref Choice))
            {
                Console.WriteLine("Higher bound is equal to the lower one");
                return true;
            }
            CF = new ChosenFunction(Math.Sin, (a, b) => true, First, Second, precision, Choice);

            if (!CF.CheckIfIn(CF.LowerBorder, CF.HigherBorder))
            {
                Console.WriteLine("Function doesn't exist in this area");
                return true;
            }
            Console.WriteLine($"{CF.LowerBorder}  {CF.HigherBorder}, {CF.Func(5)}");
            CF.Action(CF);
            return true;
        }

        public bool SquareRoot()
        {
            Console.Clear();

            double First = 0, Second = 0, precision = 0;
            int Choice = 0;
            if (!Check.InputAndCheck(ref First, ref Second, ref precision, ref Choice))
            {
                Console.WriteLine("Higher bound is equal to the lower one");
                return true;
            }
            CF = new ChosenFunction(Math.Sqrt, (a, b) => a >= 0 && b >= 0, First, Second, precision, Choice);
            if (!CF.CheckIfIn(CF.LowerBorder, CF.HigherBorder))
            {
                Console.WriteLine("Function doesn't exist in this area");
                return true;
            }
            Console.WriteLine($"{CF.LowerBorder}  {CF.HigherBorder}, {CF.Func(5)}");
            CF.Action(CF);
            return true;

        }
        public bool Quit()
        {
            Console.Clear();
            Console.WriteLine("GOODBYE!");
            return false;
        }
    }
}
