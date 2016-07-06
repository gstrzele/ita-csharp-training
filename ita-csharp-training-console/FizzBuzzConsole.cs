using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ita_chsharp_training;

namespace ita_csharp_training_console
{
    class FizzBuzzConsole
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzMain();

            var result = fizzBuzz.ExecuteFizzBuzz();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}