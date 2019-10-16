using System;

namespace L03_Debugging
{
    public class TestCallStack
    {
        public static void outerMethod(bool b)
        {
            if (b)
                innerMethod();
        }

        public static void innerMethod()
        {
            Console.WriteLine("Inner method.");
        }
    }
}