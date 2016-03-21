using System;

namespace DotNetConference.Quest4
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = 3.65d + 0.05d;
            float result2 = 3.65f + 0.05f;
            Console.WriteLine(result1 == 3.7d);
            Console.WriteLine(result2 == 3.7f);
            Console.WriteLine(result1 == result2);
            Console.ReadLine();
        }
    }
}
