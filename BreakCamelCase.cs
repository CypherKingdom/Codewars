

namespace Codes
{
    public class BreakCamelCase
    {
        public static string Solution(string str)
        {
            if (str == "")
                return "";
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                    result += " ";
                result += str[i];
            }
            return result;
        }
    }
}
