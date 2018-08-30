using System;
using System.Collections.Generic;

namespace list_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // WorkingWithStrings();
            var fibonacciNumbers = new List<int> {1, 1};
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach(var item in fibonacciNumbers)
                Console.WriteLine(item);
        }

        public static void WorkingWithStrings()
        {
            var names = new List<string> { "Jonathan", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            Console.WriteLine();
            Console.WriteLine($"The list has {names.Count} people in it");

            // Console.WriteLine();
            // var index = names.IndexOf("Felipe");
            // if (index == -1)
            // {
            //     Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            // } else
            // {
            //     Console.WriteLine($"The name {names[index]} is at index {index}");
            // }
            //
            // index = names.IndexOf("Not Found");
            // if (index == -1)
            // {
            //     Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            // } else
            // {
            //     Console.WriteLine($"The name {names[index]} is at index {index}");
            // }
            Console.WriteLine();
            var index = names.IndexOf("Felipe");
            Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
