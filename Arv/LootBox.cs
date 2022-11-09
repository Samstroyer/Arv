using System;

public class LootBox
{
    public string Name { get; set; }
    public List<string> Content { get; set; }

    public virtual void Open()
    {
        foreach (var item in Content)
        {
            Console.WriteLine(item);
        }
    }
}

public class NormalBox : LootBox
{
    public NormalBox()
    {
        Name = "Normal";
        Content = new()
        {
            "Basic knife",
            "Basic rifle",
            "Basic armor",
            "Basic stuff 1",
            "Basic stuff 2",
            "Super omega rare item"
        };
    }

}

public class RareBox : LootBox
{
    public RareBox()
    {
        Name = "Rare";
        Content = new()
        {
            "Rare knife",
            "Rare rifle",
            "Rare armor",
            "Rare stuff 1",
            "Rare stuff 2",
            "Super omega omega rare item"
        };
    }
}

public class LootBoxStore
{
    private Random r = new();
    public List<LootBox> LootBoxes { get; set; }

    public LootBoxStore()
    {
        LootBoxes = new();
        for (int i = 0; i < 10; i++)
        {
            double temp = r.NextDouble();
            if (temp < 0.2)
            {
                LootBoxes.Add(new RareBox());
            }
            else
            {
                LootBoxes.Add(new NormalBox());
            }
        }
    }

    public void ListBoxes()
    {
        foreach (var item in LootBoxes)
        {

        }
    }
}