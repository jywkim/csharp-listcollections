using System;
using System.Collections.Generic;

namespace list_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Jonathan", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
