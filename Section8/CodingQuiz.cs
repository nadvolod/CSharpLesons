using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section8
{
    [TestClass]
    public class CodingQuiz
    {
        [TestMethod]
        public void Nested_Loops_Practice()
        {
            
            int outer = 0;
            while(outer < 3)
            {
                int inner = 10;
                while (inner > 5)
                {
                    Console.WriteLine($"Outer: {outer}\tInner: {inner}");
                    inner--;
                }

                outer++;

            }
        }
    }
}
