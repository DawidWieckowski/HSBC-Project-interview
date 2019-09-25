using System;
using System.Collections.Generic;
using System.Text;

namespace Excersise
{
    public static class Task2
    {
        public static int Factorial(int number)
        {
            int result = 1;

            for(int i = 1; i <= number; i++)            
                result *= i;

            return result;
        }
    }
}
