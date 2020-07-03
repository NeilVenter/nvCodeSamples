using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace nvCodeSamples
{
    public class ArraySamples
    {
        public int MostFrequentOccurring(int[] intArray)
        {
            int maxCount = 0;
            int maxItem = -1;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach (int key in intArray)
            {
                if (keyValuePairs.ContainsKey(key))
                {
                    keyValuePairs[key] += 1;
                    if (keyValuePairs[key] > maxCount)
                    {
                        maxCount = keyValuePairs[key];
                        maxItem = key;
                    }
                }
                else
                {
                    keyValuePairs.Add(key, 1);
                }
            }

            return maxItem;
        }
        public List<int> CommonElements(int[] Array1, int[] Array2)
        {
            List<int> commenValues = new List<int>();

            foreach (int num in Array1)
            {
                if (Array2.Contains(num))
                {
                    commenValues.Add(num);
                }
            }

            return commenValues;
        }
        public List<int> CommonElementsWithLoops(int[] Array1, int[] Array2)
        {
            List<int> commenValues = new List<int>();
            int P1 = 0;
            int P2 = 0;
            
            while(P1 < Array1.Length & P2 < Array2.Length)
            {
                if(Array1[P1] == Array2[P2])
                {
                    commenValues.Add(Array1[P1]);
                    P1 ++;
                    P2 ++;
                }
                else if(Array1[P1] > Array2[P2])
                {
                    P2 ++;
                }
                else if (Array1[P1] < Array2[P2])
                {
                    P1 ++;
                }
            }

            return commenValues;
        }
        public bool IsRotation(int[] Array1, int[] Array2)
        {

            bool isRotation = false;
            int P1 = 0;
            int P2 = 0;

            
            
            while (P1 < Array1.Length & P2 < Array2.Length)
            {
                if (Array1[P1] == Array2[P2])
                {
                    //commenValues.Add(Array1[P1]);
                    P1++;
                    P2++;
                }
                else if (Array1[P1] > Array2[P2])
                {
                    P2++;
                }
                else if (Array1[P1] < Array2[P2])
                {
                    P1++;
                }
            }

            return true;
        }
    }
}
