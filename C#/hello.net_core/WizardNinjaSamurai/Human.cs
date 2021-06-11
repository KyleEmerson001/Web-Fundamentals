using System;
namespace WizardNinjaSamurai{
public abstract class Human
{
    public abstract string Name{ get; set; }
    public abstract int Strength{ get; set; }
    public abstract int Intelligence{ get; set; }
    public abstract int Dexterity{ get; set; }
    public abstract int Health{ get; set; }
}
}