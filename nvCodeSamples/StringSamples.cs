using System;
using System.Collections.Generic;
using System.Text;

namespace nvCodeSamples
{
    public class StringSamples
    {
        public char? NonRepeating(string str)
        {
            Dictionary<char, int> countDictionary = new Dictionary<char, int>();
            char? nonRepeater = null;

            foreach (char c in str)
            {
                if (!countDictionary.ContainsKey(c))
                {
                    countDictionary.Add(c, 1);
                }
                else
                {
                    countDictionary[c]++;

                }
            }
            foreach (char c in str)
            {
                if (countDictionary[c] == 1)
                {
                    nonRepeater = c;
                    break;
                }
            }
            return nonRepeater;
        }
        public bool IsOneEditAway(string str1, string str2)
        {
            int leghtDifference = Math.Abs(str1.Length - str2.Length);
            
            if (leghtDifference > 1)
            {
                return false;
            }
            if (str1 == str2)
            {
                return true;
            }
            if (str1.Length == str2.Length)
            {
                return IsOneEditAwaySameLength(str1, str2);
            }
            else if (str1.Length > str2.Length)
            {
                return IsOneEditAwayDiffLeght(str1, str2);
            }
            else
            {
                return IsOneEditAwayDiffLeght(str2, str1);
            }

        }
        public bool IsOneEditAwaySameLength(string str1, string str2)
        {
            int countDiff = 0;
            for (int i = 0; i < str1.Length -1; i++)
            {
                if (str1[i] != str2[i])
                {
                    countDiff++;
                    if (countDiff > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsOneEditAwayDiffLeght(string str1, string str2)
        {
            int countDiff = 0;
            int i = 0;
            while (i < str1.Length -1)
            {
                if (str1[i + countDiff] != str2[i])
                {
                    countDiff++;
                    if (countDiff > 1)
                    {
                        return false;
                    }
                }
                i++;
            }
            return true;
        }
    }
}
