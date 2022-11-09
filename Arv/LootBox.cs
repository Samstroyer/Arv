using System;

public class LootBox
{
    public string Name { get; set; } = "--placeholder--";
    public List<string> Content { get; set; } = new() { "empty" };

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

    public override void Open()
    {
        Console.WriteLine("Opening normal box, these are your items:");
        base.Open();
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

    public override void Open()
    {
        Console.WriteLine("Opening rare box, these are your items:");
        base.Open();
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

    public void Open()
    {
        Console.WriteLine("These are your boxes:");
        int temp = 1;
        foreach (var item in LootBoxes)
        {
            Console.WriteLine($"{temp}: {item.Name}");
            temp++;
        }

        bool choosing = true, inRange = false;
        int selection;
        do
        {
            Console.WriteLine("Enter the number of the box you want to open");

            choosing = int.TryParse(Console.ReadLine(), out selection);

            inRange = selection > 0 && selection <= LootBoxes.Count;
        } while (!choosing && inRange);

        LootBoxes[selection].Open();
        LootBoxes.RemoveAt(selection);

    }

    public void Open(int i)
    {
        int index = i - 1;

        if (index >= 0 && index < LootBoxes.Count)
        {
            LootBoxes[index].Open();
            LootBoxes.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("Box number not existing!\nWrite from 0 up to {0}", LootBoxes.Count);
        }
    }
}