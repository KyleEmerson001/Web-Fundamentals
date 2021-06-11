using System;
namespace WizardNinjaSamurai
{
    class Samurai : Human, IDamageable
    {
        public override string Name { get; set; }
        public override int Strength { get; set; }
        public override int Intelligence { get; set; }
        public override int Dexterity { get; set; }
        public override int Health { get; set; }
        public Samurai(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 200;
        }

        public Samurai(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
        }

        // Build Attack method
        public int Attack(IDamageable target)
        {
            int dmg = 0;
            if (target.Health < 50)
            {
                dmg = target.Health;
            }
            if (target.Health >= 50)
            {
                dmg = Strength * 3;
            }
            target.TakeDamage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Meditate(string name)
        {
            Health = 200;
            return Health;
        }
        public int TakeDamage(int amnt)
        {
            Health -= amnt;
            return Health;
        }

    }
}