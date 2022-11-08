using System;

public class MechComponent
{
    protected static Random r = new();
    public string Name { get; set; } = "not set";
    public int Weight { get; set; } = -1;
}

public class Armor : MechComponent
{
    public int Rating { get; set; }

    public Armor()
    {
        Name = "Armor";
        Rating = r.Next(10);
    }
}

public class Weapon : MechComponent
{
    public int Damage { get; set; }

    public Weapon()
    {
        Name = "Weapon";
        Damage = r.Next(15);
    }
}