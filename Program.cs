using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evans = numbers.Where(x => x % 2 == 0); // foreach(var x in numbers)

            foreach(var num in evans)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            var something = numbers.Where(x => x > 4);

            foreach(var num in something)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            //Min Numbers
            Console.WriteLine(numbers.Max());

            //Max numbers
            Console.WriteLine(numbers.Min());

            //Sum of numbers
            Console.WriteLine(numbers.Sum());

            //Average
            Console.WriteLine(numbers.Average());

            Console.WriteLine();


            numbers.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
;        }
    }
}
