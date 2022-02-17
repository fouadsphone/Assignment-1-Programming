using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Models;

namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rational num1 = new Rational(5,2);
            Rational num2 = new Rational(2,1);
            Rational num3 = new Rational(9,5);
            Rational num4 = new Rational(2,8);

            Console.Write("The first rational is:");
            Console.WriteLine(" " + num1);

            Console.Write("The second rational is:");
            Console.WriteLine(" " + num2);

            Console.Write("The addition of these rationals is: " + num1 + " + " + num2 + " = ");
            num1.IncreaseBy(num2);
            Console.WriteLine(" " + num1 + "\n");

            Console.Write("The third rational is:");
            Console.WriteLine(" " + num3);

            Console.Write("The fourth rational is:");
            Console.WriteLine(" " + num4);

            Console.Write("The subtraction of these rationals is: " + num3 + " - " + num4 + " = ");
            num3.DecreaseBy(num4);
            Console.WriteLine(" " + num3);

        }
    }
}