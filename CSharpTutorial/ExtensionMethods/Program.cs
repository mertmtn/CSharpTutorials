using DateTimeExtension;
using MathExtension;
using StringExtension;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("String Extension");
            string cumle = "mert metin";
            Console.WriteLine("ToUpperFirstCharacter():" + cumle.ToUpperFirstCharacter());
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("DateTime Extension");
            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih.DateWithTime());
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("Math Extension");
            Console.Write("Enter a number: ");
            var number = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cube: {0} - Square {1} - Factorial {2}", number.ToCube(), number.ToSquare(), number.ToFactorial());
            Console.WriteLine("-----------------------------------------");

            Console.Write("Multiply With: ");
            double multiplyBy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result is {0}", number.MultiplyBy(multiplyBy));
            Console.WriteLine("-----------------------------------------");


            double[] numberList = { 5.2, 7.0, 6.1 };

            double result = 1;

            foreach (var item in numberList)
            {
                result = result.MultiplyBy(item);
            }

            Console.WriteLine("numberList result is {0}", result);

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("IsPositive:{0}", number.IsPositive());
            Console.WriteLine("IsNegative:{0}", number.IsNegative());

            Console.WriteLine("Digit Number:{0}", number.GetNumberOfDigits());
            Console.ReadLine();
        }

     
    }
}
