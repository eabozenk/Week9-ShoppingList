using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLoctaion = @"C:\Users\...\Downloads\Nädal 8 - failid-20220513\ShoppingList";
            string fileName = @"\\MyShoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLoctaion}{fileName}");
            List<string> MyShoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Kas soovid midagi lisada MyShoppingListi? J/E:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'j')
                {
                    Console.WriteLine("Sisesta oma soov:");
                    string userWish = Console.ReadLine();
                    MyShoppingList.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Kena päeva!");
                }
            }

            Console.Clear();

            foreach (string wish in MyShoppingList)
            {
                Console.WriteLine($"Teie soov: {wish}");
            }

            File.WriteAllLines($"{fileLoctaion}{fileName}", MyShoppingList);
        }
    }
}
