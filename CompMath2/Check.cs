using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMath2
{
    public static class Check
    {
        public static bool InputAndCheck(ref double First, ref double Second, ref double Precision, ref int Choice)
        {
            bool FirstIn = false, SecondIn = false;
            while (!FirstIn || !SecondIn)
            {
                Console.WriteLine("Input lower border of integration");
                FirstIn = Double.TryParse(Console.ReadLine(), out First);
                Console.WriteLine("Input higher border of integration");
                SecondIn = Double.TryParse(Console.ReadLine(), out Second);

            }
            if (First > Second)
            {
                Calculations.Swap(ref First, ref Second);
            }
            if (First == Second)
            {
                return false;
            }
            bool PrecisionInput = false;
            while (!PrecisionInput)
            {
                Console.WriteLine("Enter the precision : ");
                PrecisionInput = Double.TryParse(Console.ReadLine(), out Precision);
            }

            bool CorrectChoice = false;
            while (!CorrectChoice)
            {
                Console.WriteLine("1.Left-sided\n2.Right-Sided\n3.Midpoint");
                CorrectChoice = int.TryParse(Console.ReadLine(), out Choice);
                if (Choice == 1 || Choice == 2 || Choice == 3)
                {
                    CorrectChoice = true;
                }
            }
            return true;
        }
        
    }
}
