using System;

namespace section14
{
    delegate void Procedure();
    public delegate int PerformCalculation(int x, int y);

    class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        public void Method3()
        {
            Console.WriteLine("Method 3");
        }

        public static void Main()
        {
            Procedure someProcs = null;

            someProcs += new Procedure(DelegateDemo.Method1);
            someProcs += new Procedure(Method2);  // Example with omitted class name

            DelegateDemo demo = new DelegateDemo();

            someProcs += new Procedure(demo.Method3);
            someProcs();
        }
    }
}