﻿using System;

namespace GenericCountMethodDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementCount = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 1; i <= elementCount; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Add(input);
            }

            double comparisonElement = double.Parse(Console.ReadLine());

            Console.WriteLine(box.CountElementsGreaterThanValue(comparisonElement));
        }
    }
}
