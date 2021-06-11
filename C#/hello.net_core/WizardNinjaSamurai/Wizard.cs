using System;
namespace WizardNinjaSamurai{
class Wizard: Human, IDamageable
{
    public override string Name { get; set; }
    public override int Strength { get; set; }
    public override int Intelligence { get; set; }
    public override int Dexterity { get; set; }
    public override int Health { get; set; }
     
    public Wizard(string name)
    {
        Name = name;
        Strength = 3;
        Intelligence = 25;
        Dexterity = 3;
        Health = 50;
    }
     
    public Wizard(string name, int str, int intel, int dex, int hp)
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
        int dmg = Intelligence * 5;
        target.TakeDamage(Intelligence * 5);
        Health +=dmg;
        Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
        Console.WriteLine($"{Name} healed {Name} for {dmg} Health!");
        
        return target.Health;
    }
    public int Heal(IDamageable target)
    {
        int heal = Intelligence * 10;
        target.Health += heal;
        Console.WriteLine($"{Name} healed {target.Name} of {heal} damage!");
        return target.Health;
    }
    public int TakeDamage(int amnt)
        {
                Health -= amnt;
            return Health;
        }
}

}
