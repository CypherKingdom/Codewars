/*
    Write a function that takes an integer as input, and returns the number of bits 
    that are equal to one in the binary representation of that number. 
    You can guarantee that input is non-negative.

    Example: The binary representation of 1234 is 10011010010, 
    so the function should return 5 in this case
*/

namespace Codes
{
    public class BitCounting
    {
        public static int Solution(int n)
        {
            string binaryValue = Convert.ToString(n, 2);
            int count = 0;
            foreach (char val in binaryValue)
                if (val == '1')
                    count++;
            return count;

            //return Convert.ToString(n, 2).Count(x => x == '1');
        }
    }
}
