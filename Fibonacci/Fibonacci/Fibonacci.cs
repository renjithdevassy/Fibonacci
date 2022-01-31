using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static string Fib(int number)
        {
            string Sum;
           if(number < 1)
            {
                return "0";
            }
            else
            {
                int a = 0, b = 1, c = 0;
                Sum = "0 , 1";
                for (int i = 2; i < number; i++)
                {
                    c = a + b;
                    Sum = Sum + "," + c;
                    a = b;
                    b = c;
                }
                return Sum;

            }
        }
    }
}
