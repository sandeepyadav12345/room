using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            string firstNumber = Console.ReadLine();
            int x = 0;
            bool y = int.TryParse(firstNumber, out x);
            while (!y)
            {
                Console.WriteLine("please enter valid value");
                firstNumber = Console.ReadLine();
                y = int.TryParse(firstNumber, out x);


            }
            Console.WriteLine("Enter second number");
            string SecondNumber = Console.ReadLine();
            int m = 0;
            bool n = int.TryParse(SecondNumber, out m);
            while (!n)
            {
                Console.WriteLine("please enter valid value");
                SecondNumber = Console.ReadLine();
                n = int.TryParse(firstNumber, out m);


            }
            int z;
            Console.WriteLine("choose the operator(+,-,/,*)");
            string calc = Console.ReadLine();
            switch (calc)
            {
                case "+":
                     z = x + m;
                    Console.WriteLine(z);
                    Console.ReadKey();
                    break;
                case "-":
                    z = x - m;
                    Console.WriteLine(z);
                    Console.ReadKey();
                    break;
                case "*":
                     z = x * m;
                    Console.WriteLine(z);
                    Console.ReadKey();
                    break;
                case "/":
                     z = x / m;
                    Console.WriteLine(z);
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("invalid operator");
                    Console.ReadKey();
                    break;


            }
           





        }
    }
}
