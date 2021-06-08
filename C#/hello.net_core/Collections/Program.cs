using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1;
            array1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string[] array2;
            array2 = new string[] { "Tim", "Martin", "Nikki", "Sara" };

            bool[] array3;
            array3 = new bool[10];
            array3[0] = true;
            array3[1] = false;
            array3[2] = true;
            array3[3] = false;
            array3[4] = true;
            array3[5] = false;
            array3[6] = true;
            array3[7] = false;
            array3[8] = true;
            array3[9] = false;

            List<string> iceCream = new List<string>();
            iceCream.Add("Vanilla");
            iceCream.Add("Chocolate");
            iceCream.Add("Strawberry");
            iceCream.Add("Blue berry");
            iceCream.Add("Mocha");
            Console.WriteLine(iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);

            Dictionary<string, string> FlavorFav = new Dictionary<string, string>();
            Random rnd = new Random();
            FlavorFav.Add("Tim", iceCream[rnd.Next(0,5)]);
            FlavorFav.Add("Martin", iceCream[rnd.Next(0,5)]);
            FlavorFav.Add("Nikki", iceCream[rnd.Next(0,5)]);
            FlavorFav.Add("Sara", iceCream[rnd.Next(0,5)]);
            foreach (var entry in FlavorFav)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}


            Console.WriteLine(array1[0]);
            Console.WriteLine(array2[0]);
            Console.WriteLine(array3[0]);
        }
    }
}
