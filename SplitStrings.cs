/*
    Complete the solution so that it splits the string into pairs of two characters. 
    If the string contains an odd number of characters then it should replace the 
    missing second character of the final pair with an underscore ('_').

    Examples:
    - 'abc' =>  ['ab', 'c_']
    - 'abcdef' => ['ab', 'cd', 'ef'] 
*/

namespace Codes
{
    public class SplitStrings
    {
        public static string[] Solution(string str)
        {
            if (str.Length % 2 != 0)
                str += "_";
            string[] result = new string[str.Length / 2];
            for (int i = 0; i < str.Length; i += 2)
                result[i / 2] = str.Substring(i, 2);
            return result;
        }
    }
}
