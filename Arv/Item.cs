using System;

public class Item
{
    protected static Random r = new();
    public string Name { get; set; } = "null";
    public int Rarity { get; set; } = -1;
}

public class Tool : Item
{
    public Tool(string name)
    {
        Name = name;
        Rarity = r.Next(0, 10);
    }
}

public class Crystal : Item
{
    public Crystal(string name)
    {
        Name = name;
        Rarity = r.Next(0, 5);
    }
}