using System;

namespace FactoryPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("How many wheels are on your vehical?");
           var answer = Console.ReadLine();
           var x = Factory.GetVehical(answer);
            x.Drive();

        }   
    }
}
