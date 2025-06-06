﻿/*
    Write a function that will return the count of distinct case-insensitive alphabetic
    characters and numeric digits that occur more than once in the input string. 
    The input string can be assumed to contain only alphabets (both uppercase and lowercase) 
    and numeric digits.

    Example
    "abcde" -> 0 # no characters repeats more than once
    "aabbcde" -> 2 # 'a' and 'b'
    "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
    "indivisibility" -> 1 # 'i' occurs six times
    "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
    "aA11" -> 2 # 'a' and '1'
    "ABBA" -> 2 # 'A' and 'B' each occur twice
*/

namespace Codes
{
    public class CountingDuplicates
    {
        public static int Solution(string str)
        {
            int count = 0;
            string newstr = str.ToLower();
            for (int i = 0; i < newstr.Length - 1; i++)
            {
                if (newstr.Substring(i + 1, newstr.Length - i - 1).Contains(newstr[i]))
                {
                    if (newstr[..(i)].Contains(newstr[i]))
                        continue;
                    count++;
                }
            }
            return count;

            //return str.ToLower().GroupBy(x => x).Count(x => x.Count() > 1);

            //var charCount = new Dictionary<char, int>();
            //string newstr = str.ToLower();

            //foreach (char c in newstr)
            //{
            //    if (charCount.ContainsKey(c))
            //    {
            //        charCount[c]++;
            //    }
            //    else
            //    {
            //        charCount[c] = 1;
            //    }
            //}

            //return charCount.Count(x => x.Value > 1);
        }
    }
}
