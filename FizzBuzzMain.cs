using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ita_chsharp_training
{
    public class FizzBuzzMain
    {
        //This is parameterless constructor
        public FizzBuzzMain()
        {
           

        }
        public string ExecuteFizzBuzz(int num)
        {
            Boolean div5 = (num % 5 == 0);
            Boolean div3 = (num % 3 == 0);

            if (div5 && div3)
            {
                return "FizzBuzz";

            }
            else if (div5)
            {
                return "Buzz";

            }
            else if (div3)
            {
                return "Fizz";

            }
            else
            {
                return num.ToString();
            }
           
        }

        
        
    }
}
