using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ita_chsharp_training;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Fizz = new FizzBuzzMain();
            string num1;
            Console.WriteLine("Enter a number: ");
            num1 = Console.ReadLine();
            int parsed = Int32.Parse(num1);

            string returned = Fizz.ExecuteFizzBuzz(parsed);

            Console.WriteLine(returned);
            Console.ReadLine();
        }


    }
}
