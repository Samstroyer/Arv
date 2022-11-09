using System;
using System.Numerics;

public class Monster
{
    public string Name { get; set; }
    public int Hitpoints { get; set; }
    public Vector2 Position { get; set; }
    public Vector2 Velocity { get; set; }

    public virtual void Update()
    {
        Position += Velocity;
    }
}

public class Teleporter : Monster
{

}
