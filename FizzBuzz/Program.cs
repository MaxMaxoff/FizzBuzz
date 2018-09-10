using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i++<100;)
            {
                //if (i % 3 == 0) Console.Write("Fizz");
                //if (i % 5 == 0) Console.Write("Buzz");
                //if (i % 3 != 0 && i % 5 != 0) Console.Write(i);
                //Console.WriteLine();

                Console.Write("{0:#}{1:;;Fizz}{2:;;Buzz}\n", i % 3 * i % 5 > 0 ? i : 0, i % 3, i % 5);
            }

            Console.ReadKey();
        }
    }
}
