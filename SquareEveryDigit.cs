/*
    You are asked to square every digit of a number and concatenate them.
    Example 1, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1. (81-1-1-81)
    Example 2: An input of 765 will/should return 493625 because 72 is 49, 62 is 36, and 52 is 25. (49-36-25)
    Note: The function accepts an integer and returns an integer.
*/

namespace Codes
{
    public class SquareEveryDigit
    {
        public static int Solution(int n)
        {
            if (n < 10)
                return n * n;
            int result = Convert.ToInt32(Convert.ToString(Solution(n / 10)) + 
                            Convert.ToString((n % 10) * (n % 10)));
            return result;
        }
    }
}