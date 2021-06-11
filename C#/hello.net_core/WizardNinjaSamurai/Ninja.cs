using System;
namespace WizardNinjaSamurai{
class Ninja: Human, IDamageable
{
    public override string Name { get; set; }
    public override int Strength { get; set; }
    public override int Intelligence { get; set; }
    public override int Dexterity { get; set; }
    public override int Health { get; set; } 
    public Ninja(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 175;
        Health = 100;
    }
     
    public Ninja(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }
     
    // Build Attack method
    public int Attack(IDamageable target)
    {   Random r = new Random();
        int rando = r.Next(1,6);
        int att = 0;
        if (rando == 1){
            att = 10;
        }
        int dmg = Dexterity * 5 + att;
        
        target.TakeDamage(dmg);
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        return target.Health;
    }
    public int Steal(IDamageable target)
    {
        target.TakeDamage(5);
        Health += 5;
        Console.WriteLine($"{Name} attacked {target.Name} for 5 damage and healed self of 5 damage!");
        return target.Health;
    }
    public int TakeDamage(int amnt)
        {
                Health -= amnt;
            return Health;
        }
}
}
