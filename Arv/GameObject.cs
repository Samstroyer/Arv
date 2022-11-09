using System;
using System.Numerics;

public class GameObject
{
    public string Name { get; set; } = "G.O";
    public Vector2 Position { get; set; }


}


public class MovingObject : GameObject
{
    public Vector2 Velocity { get; set; }

    public MovingObject()
    {
        Name = "M.O";
    }


    public void Update()
    {
        Position += Velocity;
    }
}