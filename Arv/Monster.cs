using System;
using System.Numerics;

public class Monster
{
    public string Name { get; set; } = "--placeholder--";
    public int Hitpoints { get; set; }
    public Vector2 Position { get; set; }
    public Vector2 Velocity { get; set; }

    protected static Random r = new();

    public virtual void Update()
    {
        Position += Velocity;
    }
}

public class Teleporter : Monster
{
    public int TimerMax { get; set; } = 5;
    private int timer;

    public Teleporter()
    {
        ResetTimer();
    }

    public override void Update()
    {
        timer--;
        if (timer == 0)
        {
            RandomPosition();
            ResetTimer();
        }
    }

    private void ResetTimer()
    {
        timer = TimerMax;
    }

    private void RandomPosition()
    {
        Vector2 newPos = new(r.Next(0, 10), r.Next(0, 10));
        Position = newPos;
    }
}
