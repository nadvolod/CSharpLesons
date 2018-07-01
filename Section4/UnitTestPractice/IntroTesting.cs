using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPractice
{
    [TestClass]
    public class IntroTesting
    {
        [TestMethod]
        [Description("This test checks two numbers for equality")]
        
        public void Integers_Are_Equal()
        {
            int someNumber = 10;
            Assert.AreEqual(someNumber, 12, "These numbers are not equal");
        }

        [TestMethod]
        public void Integers_Are_Not_Equal()
        {
            int someNumber = 10;
            Assert.AreNotEqual(someNumber, 10);
        }

        [TestMethod]
        public void String_Ends_With()
        {
            string word = "no";
            StringAssert.EndsWith(word, "ing", "This test only passes if the given string ends in ing");
        }
    }
}
