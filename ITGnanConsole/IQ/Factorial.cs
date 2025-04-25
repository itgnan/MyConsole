using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace ITGnanConsole.IQ
{
    public partial class MyProgram
    {
        public static long Factorial(int n)
        {
            // Base case: factorial of 0 or 1 is 1
            if (n == 0 || n == 1)
                return 1;

            // Recursive case: factorial of n is n * factorial(n-1)
            return n * Factorial(n - 1);
        }

        public static long FactorialWO(int n)
        {
            long result = 1;

            // Calculate factorial using a loop
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
