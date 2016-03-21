using System;

namespace DotNetConference.Quest5
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta = 0.1;
            int i = 0;
            double value = 0d;
            for (; i < 100; i++)
            {
                value += delta;
            }
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
