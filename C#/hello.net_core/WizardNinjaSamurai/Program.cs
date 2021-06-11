using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard1 = new Wizard("Wizard 1");
            Ninja ninja1 = new Ninja("Ninja 1");
            Samurai samurai1 = new Samurai("Samurai 1");
            Console.WriteLine(wizard1.Health);
            ninja1.Attack(wizard1);
            ninja1.Attack(samurai1);
            samurai1.Attack(wizard1);
            Console.WriteLine(samurai1.Health);
            samurai1.Meditate("Samurai 1");
            Console.WriteLine(samurai1.Health);
            wizard1.Heal(ninja1);
            Console.WriteLine(ninja1.Health);
            ninja1.Steal(wizard1);
            Console.WriteLine(ninja1.Health);
        }
    }



}