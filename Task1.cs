using System;

namespace Excersise
{
    public static class Task1
    {
        public static int SumIntInString(string s)
        {
            int result = 0;
            int tryParseResult;

            var sArray = s.Split(" ");
            foreach (var element in sArray)
                if (int.TryParse(element, out tryParseResult))
                    result += tryParseResult;

            return result;
        }
    }
}
