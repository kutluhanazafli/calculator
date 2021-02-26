using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders
{
    class Program
    {
        static void Main(string[] args)
        {

            //Hesap Makinesi

            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("type a number and press enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("type a number and press enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choise an option from the following list:");
            Console.WriteLine("\ta-Add");
            Console.WriteLine("\ts-Subtract");
            Console.WriteLine("\td-Divide");
            Console.WriteLine("\tm-Multiply");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Result: {num1} + {num2} =" + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Result: {num1} - {num2} =" + (num1 - num2));
                    break;
                case "d":
                    Console.WriteLine($"Result: {num1} / {num2} =" + (num1 / num2));
                    break;
                case "m":
                    Console.WriteLine($"Result: {num1} * {num2} =" + (num1 * num2));
                    break;
            }

            Console.ReadKey();
        }
    }
}
