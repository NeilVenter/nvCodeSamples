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
    }
}
