using System;

namespace GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int stringCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stringCount; i++)
            {
                string input = Console.ReadLine();

                Box<string> box = new Box<string>(input);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
