/*
    ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything 
    but exactly 4 digits or exactly 6 digits.
    If the function is passed a valid PIN string, return true, else return false.

    Examples (Input --> Output)
    "1234"   -->  true
    "12345"  -->  false
    "a234"   -->  false
*/

namespace Codes
{
    public class RegexValidatePinCode
    {
        public static bool Solution(string pin)
        {
            if (pin.Length == 4 || pin.Length == 6)
            {
                foreach (char digit in pin)
                    if (!char.IsDigit(digit))
                        return false;
                return true;
            }
            return false;
        }
    }
}
