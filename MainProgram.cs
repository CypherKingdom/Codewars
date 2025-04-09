using Codes;

class MainProgram
{
    static void Main(string[] args)
    {
        int testValue = 765;
        string testValue2 = "abcdef";
        string testValue3 = "aabBcde";
        string testValue4 = "123456";
        int[] nums = [0, 1, 1, 0];

        Console.WriteLine("Digital root: " + Digital_Root.Solution(testValue));
        Console.WriteLine("Square digits: " + SquareEveryDigit.Solution(testValue));
        Console.WriteLine("Split strings: " + string.Join(", ", SplitStrings.Solution(testValue2)));
        Console.WriteLine("Bit counting: " + BitCounting.Solution(testValue));
        Console.WriteLine("Counting duplicates: " + CountingDuplicates.Solution(testValue3));
        Console.WriteLine("Regex validate PIN code: " + RegexValidatePinCode.Solution(testValue4));
        Console.WriteLine("Ones and Zeros: " + OnesandZeros.Solution(nums));
        Console.WriteLine("Break camelCase: " + BreakCamelCase.Solution(testValue3));
    }
}