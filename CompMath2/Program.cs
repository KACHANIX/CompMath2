using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompMath2
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu.Menu();
            bool myProgramIsRunning = true;
            Functions Functional = new Functions();

            menu.AddItem("x^2", Functional.Squarred);
            menu.AddItem("Sin(x)", Functional.Sin);
            menu.AddItem("√x", Functional.SquareRoot);
            menu.AddItem("Quit", Functional.Quit);

            while (myProgramIsRunning)
            {
                Console.Clear();
                myProgramIsRunning = menu.Display();
                Console.ReadKey();
            }
        }
    }
}
