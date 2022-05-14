using System;
using System.IO;

namespace Projekt1
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\...\Downloads\Nädal 8 - failid-20220513";
            Console.WriteLine("Sisesta uue kausta nimi:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisesta uue file nimi koos .txt lõpuga:");
            string fileName = Console.ReadLine();


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Teie sisestatud Kaust ja File on juba võetud.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
