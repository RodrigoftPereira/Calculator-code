using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1;
            double number2;

            string answer;
            double result = 0;// Inicializar result com um valor padrão
            bool validOperation = true; // Adicionar um indicador de operação válida


            Console.WriteLine("Hello, welcome to my calculator program!");
            Console.WriteLine("What are we gonna calculate today?");
            Console.WriteLine("For addition type a | For substraction type s | For multiplication type m | For division type d");
            answer = Console.ReadLine();

            Console.WriteLine("Enter your first number");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            number2 = Convert.ToDouble(Console.ReadLine());

            if (answer == "a" )
            {
                result = number1 + number2;
            }
            else if(answer == "s" )
            {
                result = number1 - number2;
            }
            else if (answer == "m" )
            {
                result = number1 * number2;
            }
            else if (answer == "d")
            {
                if (number2 != 0) // Verifica se o divisor não é zero
                {
                    result = number1 / number2;
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    validOperation = false;
                }
            }
            else
            {
                Console.WriteLine("Please only insert the letters given for the equations");
                validOperation = false;
            }

            if (validOperation)
            {
                Console.WriteLine("The result of your equation is: " + result);
            }

            Console.ReadKey();
        }
    }
}
