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

            Console.ReadLine();
        }


    }
}
