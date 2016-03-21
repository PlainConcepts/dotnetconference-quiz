using System;

namespace DotNetConference.Quest3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            x = x++;
            Console.WriteLine("X=={0}", x);
            Console.ReadLine();
        }
    }
}
