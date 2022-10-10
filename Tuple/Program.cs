using System;
using System.Linq;

namespace GenericTuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string personFullName = $"{personInfo[0]} {personInfo[1]}";
            string personAddress = personInfo[2];

            Console.WriteLine(new GenericTuple<string, string>(personFullName, personAddress));

            string[] personBeerLiters = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string personName = personBeerLiters[0];

            int beerLiters = int.Parse(personBeerLiters[1]);

            Console.WriteLine(new GenericTuple<string, int>(personName, beerLiters));

            string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int firstNumber = int.Parse(numbers[0]);

            double secondNumber = double.Parse(numbers[1]);

            Console.WriteLine(new GenericTuple<int, double>(firstNumber, secondNumber));
        }
    }
}
