using System;
using System.Collections.Generic;
using System.Text;

namespace Excersise
{
    public static class Task5
    {
        public static int FindOddEleement(int[] table)
        {
            int result = int.MinValue;

            foreach(var element in table)
            {
                var existingElements = Array.FindAll(table, x => x == element);
                if( existingElements.Length == 1)
                {
                    result = existingElements[0];
                    break;
                }
            }            
            
            return result;
        }
    }
}
