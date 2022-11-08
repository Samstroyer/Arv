using System;
using System.Numerics;

public class GameObject
{
    public string Name { get; set; }
    public Vector2 Position { get; set; }


}


public class MovingObject : GameObject
{
    public Vector2 Velocity { get; set; }


    public void Update()
    {
        Position += Velocity;
    }
}