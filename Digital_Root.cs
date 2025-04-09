/*
    Sum of Digits / Digital Root
    Digital root is the recursive sum of all the digits in a number.
    Given n, take the sum of the digits of n. If that value has more than one digit, 
    continue reducing in this way until a single-digit number is produced. 
    The input will be a non-negative integer.

    Examples
        16  -->  1 + 6 = 7
        942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
        132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
        493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2
*/

/*
    Base Case:
    If n is less than 10 (i.e., a single-digit number), it is returned directly as the result.
    Recursive Case:
    The function calculates the sum of the last digit (n % 10) and the digital root 
    of the remaining number (digital_root(n / 10)).
    If the resulting sum is still greater than or equal to 10, the function recursively 
    calls itself again to compute the digital root of the new value.
    Efficiency:
    Uses recursion to break down the number into its digits and calculate the sum iteratively.
    Time complexity depends on the number of digits in n, making it O(log(n)).
*/

namespace Codes
{
    public class Digital_Root
    {
        public static int Solution(int n)
        {
            if (n < 10)
                return n;
            int result = n % 10 + Solution(n / 10);
            return Solution(result);
        }
    }
}