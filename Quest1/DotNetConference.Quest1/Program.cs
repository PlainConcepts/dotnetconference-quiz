using System;

namespace DotNetConference.Quest1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("With same reference: ");
            Test(out a, out a);
            Console.WriteLine("With different reference: ");
            Test(out b, out a);
            Console.ReadLine();
        }

        static void Test(out int x, out int y)
        {
            x = 42;
            y = 123;
            Console.WriteLine(x == y);
        }
    }
}
