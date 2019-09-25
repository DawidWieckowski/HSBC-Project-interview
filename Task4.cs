using System;
using System.Collections.Generic;
using System.Text;

namespace Excersise
{
    public static class Task4
    {
        public static void ShowOutputFromOneToTen()
        {
            for(int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine("Three");
                else if (i % 3 == 0)
                    Console.WriteLine("One");
                else if (i % 5 == 0)
                    Console.WriteLine("Two");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
