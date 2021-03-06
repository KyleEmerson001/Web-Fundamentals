using System;
using System.Collections.Generic;
namespace Puzzels
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int max = 0;
            int min = 25;
            int total = 0;
            Random rnd = new Random();

            for (int i = 0; i <= 9; i++)
            {
                num[i] = rnd.Next(5, 26);
                if (num[i] > max)
                {
                    max = num[i];
                }
                if (num[i] < min)
                {
                    min = num[i];
                }
                total = total + num[i];
            }

            Console.WriteLine(total);
            Console.WriteLine(max);
            Console.WriteLine(min);

            static string TossCoin()
            {
                Random rnd = new Random();
                string results = "";
                int Coin = rnd.Next(1, 3);
                if (Coin == 1)
                {
                    Console.WriteLine("Tossing a Coin!");
                    results = "Heads";
                    Console.WriteLine(results);
                    return "Heads";
                }
                if (Coin == 2)
                {
                    Console.WriteLine("Tossing a Coin!");
                    results = "Tails";
                    Console.WriteLine(results);
                    return "Tails";
                }
                Console.WriteLine(results);
                return results;
            }
            TossCoin();

            static void TossMultipleCoins(int numb)
            {
                Double ratio = 0.0;
                for (var i = 0; i < numb; i++)
                {
                    string flip = TossCoin();
                    if (flip == "Heads")
                    {
                        ratio = ratio + 1;
                    }
                    if (flip == "Tails")
                    {
                        ratio = ratio + 0;
                    }
                    Console.WriteLine(ratio / numb);
                }
            }
            TossMultipleCoins(9);

            static List<string> Names()
            {
                List<string> names = new List<string>(){"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
                List<string> Shuffled = new List<string> ();
                foreach (string i in names){
                    Random rnd = new Random();
                    Shuffled.Insert(rnd.Next(0, Shuffled.Count+1), i);
                }
                for (int i = 0; i<Shuffled.Count; i++){
                    if(Shuffled[i].Length < 5){
                        Shuffled.RemoveAt(i);
                    }
                }
                return Shuffled;
            }
           



            Names();
        }
    }
}
