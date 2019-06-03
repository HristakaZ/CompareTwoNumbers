using System;

namespace CompareTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 3.671376F;
            float b = 7.436179173F;
            bool equal = Math.Abs(a - b) > 0.000001;
            Console.WriteLine(equal); //returns true.
        }
    }
}
