using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;

namespace nvCodeSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArraySamples arraySamples = new ArraySamples();
            int[] arrayMostFrequent = { 1, 2, 3, 1 };

            int result = arraySamples.MostFrequentOccurring(arrayMostFrequent);
            Console.WriteLine($"{result} occurred most in the given array");


            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 1, 3, 9 };
            List<int> commonValues = arraySamples.CommonElements(array1, array2);

            foreach (int value in commonValues)
            {
                Console.WriteLine($"{value} occurred in both the given arrays using contains");
            }

            List<int> commonValuesWithLoops = arraySamples.CommonElementsWithLoops(array1, array2);

            foreach (int value in commonValuesWithLoops)
            {
                Console.WriteLine($"{value} occurred in both the given arrays when using loops");
            }

            int[] array3 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] array4 = { 4, 5, 6, 7, 1, 2, 3 };

            bool isRotation = arraySamples.IsRotation(array3, array4);
            string message = isRotation ? "TRUE: The two arrays are rotations of one another" : "FALSE: These two arrays are NOT rotations of one anoter"; 
            Console.WriteLine($"{message}");

            //test string
            StringSamples stringSamples = new StringSamples();
            string testStr = "bbaccdds";

            char? nonRepeater = stringSamples.NonRepeating(testStr);

            Console.WriteLine($"The value that did not repeat is: {nonRepeater}");

            //One Edit away
            string testStr1 = "a";
            string testStr2 = "a";

            bool isOneEdit = stringSamples.IsOneEditAway(testStr1, testStr2);
            Console.WriteLine($"The two strings are one edit away: {isOneEdit}");

            Console.ReadLine();
        }


    }
}
