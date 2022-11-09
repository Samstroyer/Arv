using System;

public class Avatar
{
    public string Name { get; set; } = "--placeholder--";
    public int Hitpoints { get; set; }
}

public class Potion
{
    public short UseValue { get; set; } = 0;

    public virtual void Use(Avatar a)
    {
        a.Hitpoints += UseValue;
    }
}

public class HealthPotion : Potion
{
    public HealthPotion()
    {
        UseValue = 10;
    }

    public override void Use(Avatar a)
    {
        base.Use(a);
        Console.WriteLine("Avatar {0} got 10hp!", a.Name);
    }
}

public class PoisonPotion : Potion
{
    public PoisonPotion()
    {
        UseValue = -10;
    }

    public override void Use(Avatar a)
    {
        base.Use(a);
        Console.WriteLine("Avatar {0} lost 10hp!", a.Name);
    }
}