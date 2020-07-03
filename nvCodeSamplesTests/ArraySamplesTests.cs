using Microsoft.VisualStudio.TestTools.UnitTesting;
using nvCodeSamples;
using System;
using System.Collections.Generic;
using System.Text;

namespace nvCodeSamples.Tests
{
    [TestClass()]
    public class ArraySamplesTests
    {
        [TestMethod()]
        public void MostFrequentOccurringTest()
        {
            ArraySamples arraySamples = new ArraySamples();
            int[] arrayMostFrequent = { 1, 2, 3, 1 };
            int result = arraySamples.MostFrequentOccurring(arrayMostFrequent);

            Assert.AreEqual(1, result, "The Value should be 1");
        }

        [TestMethod()]
        public void CommonElementsTest()
        {
            ArraySamples arraySamples = new ArraySamples();
            int[] array1 = { 1, 2, 3, 4 };
            int[] array2 = { 1, 3, 9 };

            string actual = "";
            List<int> commonValues = new List<int>();
            commonValues = arraySamples.CommonElements(array1, array2);
            foreach (int value in commonValues)
            {
                actual += value + ",";
            }
            actual = actual.Substring(0, actual.Length - 1);


            Assert.AreEqual("1,3", actual);
        }

        [TestMethod()]
        public void IsRotationTest()
        {
            ArraySamples arraySamples = new ArraySamples();
            int[] array3 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] array4 = { 4, 5, 6, 7, 1, 2, 3 };

            bool result = arraySamples.IsRotation(array3, array4);

            Assert.AreEqual(true,result,"This should be true as it is a rotation");
        }
    }
}