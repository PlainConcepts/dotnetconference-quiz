using System;

namespace DotNetConference.Quest2
{
    class Program
    {
        static void Main(string[] args)
        {
            float value = 100000000;
            while(value > 0)
            {
                --value;
            }
            Console.WriteLine("Value es {0}", value);
            Console.ReadLine();
        }
    }
}
