using System;

namespace GenericBoxOfInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int stringCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stringCount; i++)
            {
                int input = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
