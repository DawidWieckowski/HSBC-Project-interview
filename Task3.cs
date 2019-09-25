using System;
using System.Collections.Generic;
using System.Text;

namespace Excersise
{
    public static class Task3
    {
        public static int FindClosestToZero(int[] array)
        {
            int result = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
                if (Math.Abs(result) > Math.Abs(array[i]))
                    result = array[i];

            if (Array.Exists(array, element => element == Math.Abs(result)))
                result = Math.Abs(result);

            return result;
        }
    }
}
