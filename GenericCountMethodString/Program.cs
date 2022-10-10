using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int elementCount = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 1; i <= elementCount; i++)
            {
                string input = Console.ReadLine();

                box.Add(input);
            }

            string comparisonElement = Console.ReadLine();

            Console.WriteLine(box.CountElementsGreaterThanValue(comparisonElement));
        }
    }
}
