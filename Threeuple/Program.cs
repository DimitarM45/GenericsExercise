using System;

namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string personFullName = $"{personTokens[0]} {personTokens[1]}";
            string personAddress = personTokens[2];
            string personTown;

            if (personTokens.Length > 4)
                personTown = $"{personTokens[3]} {personTokens[4]}";

            else
                personTown = personTokens[3];

            Console.WriteLine(new Threeuple<string, string, string>(personFullName, personAddress, personTown));

            string[] beerTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string personName = beerTokens[0];

            int beerLiters = int.Parse(beerTokens[1]);

            bool isDrunk = beerTokens[2] == "drunk" ? true : false;

            Console.WriteLine(new Threeuple<string, int, bool>(personName, beerLiters, isDrunk));

            string[] bankTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = bankTokens[0];

            double balance = double.Parse(bankTokens[1]);

            string bankName = bankTokens[2];

            Console.WriteLine(new Threeuple<string, double, string>(name, balance, bankName));
        }
    }
}
