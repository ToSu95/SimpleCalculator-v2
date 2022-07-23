using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var calculator = new Calculate();

            while (true)
            {
            Console.WriteLine("Prosty kalkulator");
            

            Console.WriteLine("Podaj 1 liczbę:");
            var numberOne = calculator.GetNumberOne();

            Console.WriteLine("Podaj 2 liczbę:");
            var numberTwo = calculator.GetNumberTwo();

            Console.WriteLine("Podaj operację jaką chcesz wykonać, możliwe operacje to: '+', '-', '*', '/'.");
            var action = Console.ReadLine();

            var result = calculator.GetAction(numberOne, numberTwo, action);

            Console.WriteLine("Wynik: {0}", result);

            Console.WriteLine("Jeśli chcesz wyjść z kalkulatora, podaj 'n'. W przeciwnym wypadku podaj 'y'");

            var userChoice = Console.ReadLine();

            if (userChoice == "n")
              {
                Environment.Exit(0);
              }
            else if (userChoice == "y")
              {
                continue;
              }

            }
        }
    }
}
