using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGnanConsole.IQ
{
    public partial class MyProgram
    {
        public static void Fibonacci(int n)
        {
            int num1 = 0, num2 = 1, nextTerm;

            Console.WriteLine("Fibonacci Series up to " + n + " terms:");

            for (int i = 1; i <= n; i++)
            {
                Console.Write(num1 + " ");

                nextTerm = num1 + num2;
                num1 = num2;
                num2 = nextTerm;
            }
        }
    }
}
