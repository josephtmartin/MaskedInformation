using System;

namespace MaskedInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Psst Hey! Tell me a secret, promise I won't tell");
            var secret = Console.ReadLine();
            var maskedSecret = secret.Substring(secret.Length - 4).PadLeft(secret.Length, '*');

            Console.WriteLine(maskedSecret);
        }
    }
}
