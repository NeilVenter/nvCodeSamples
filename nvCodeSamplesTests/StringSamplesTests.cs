using Microsoft.VisualStudio.TestTools.UnitTesting;
using nvCodeSamples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace nvCodeSamples.Tests
{
    [TestClass()]
    public class StringSamplesTests
    {
        [TestMethod()]
        public void NonRepeatingTest()
        {
            StringSamples stringSamples = new StringSamples();
            string testStr = "bbaccdds";

            char? result = stringSamples.NonRepeating(testStr);

            Assert.AreEqual('a', result, "Must return a");

        }
    }
}