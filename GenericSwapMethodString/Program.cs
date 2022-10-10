using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int boxCount = int.Parse(Console.ReadLine());

            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 1; i <= boxCount; i++)
            {
                string input = Console.ReadLine();

                boxes.Add(new Box<string>(input));
            }

            int[] indexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SwapElements<Box<string>>(boxes, indexes[0], indexes[1]);

            foreach (Box<string> box in boxes)
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
