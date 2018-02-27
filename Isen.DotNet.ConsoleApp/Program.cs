using System;
using Isen.DotNet.Library;

namespace Isen.DotNet.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var greet = Hello.Greet("Kall");
            Console.WriteLine(greet);
            var greetupper = Hello.GreetUpper("Kall");
            Console.WriteLine(greetupper);
        }
    }
}
