using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_v2
{
    internal class Calculate
    {
        public int GetNumberOne()
        {                                         

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
              Console.WriteLine("Podałeś nieprawidłowe dane!");
                
            }

            return number;
            
        }

        public int GetNumberTwo()
        {

            if (!int.TryParse(Console.ReadLine(), out int number))
            {
              Console.WriteLine("Podałeś nieprawidłowe dane!");

            }

            return number;

        }        

        public int GetAction(int numberOne, int numberTwo, string action)
        {
            switch(action)
            {
                case "+":
                    return numberOne + numberTwo;   
                case "-":
                    return numberOne - numberTwo;
                case "*":
                    return numberOne * numberTwo;
                case "/":
                    return numberOne / numberTwo;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }
        }
    }
}
