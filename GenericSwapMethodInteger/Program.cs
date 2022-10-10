using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int boxCount = int.Parse(Console.ReadLine());

            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 1; i <= boxCount; i++)
            {
                int input = int.Parse(Console.ReadLine());

                boxes.Add(new Box<int>(input));
            }

            int[] indexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SwapElements<Box<int>>(boxes, indexes[0], indexes[1]);

            foreach (Box<int> box in boxes)
                Console.WriteLine(box.ToString());
        }

        static void SwapElements<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T tempElemement = list[firstIndex];

            list[firstIndex] = list[secondIndex];

            list[secondIndex] = tempElemement;
        }
    }
}
