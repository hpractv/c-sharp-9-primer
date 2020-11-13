using System;

namespace c_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No Skippy");
            NoSkippy();
            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine("\nSkippy");
                Skippy();
            }
        }


        [System.Runtime.CompilerServices.SkipLocalsInitAttribute]
        static void Skippy()
        {
            Span<int> nums = stackalloc int[10];
            foreach (var x in nums) Console.WriteLine(x);
        }

        static void NoSkippy()
        {
            Span<int> nums = stackalloc int[10];
            foreach (var x in nums) Console.WriteLine(x);
        }
    }
}
