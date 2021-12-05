using System;

namespace DebApp
{
    class Program
    {
        static void Main(string[] args)
        {
	    var i = 0;
	    foreach (var arg in args)
	    {
            	i = i + 1;
		Console.WriteLine($"Argument number {i} is {arg}");
	    }
        }
    }
}
