﻿//Assignment on inheritance - Samuel Palmér TE20A

using System.Numerics;

Console.WriteLine("Student test:");
Student s = new Student();
Console.WriteLine("Name: " + s.Name + "\nAge: " + s.Age + "\nSchool: " + s.School);
Console.Read();


Console.WriteLine("Moving Object test:");
MovingObject o = new MovingObject();
o.Velocity = new Vector2(1, 0);
Console.WriteLine(o.Position.X);
o.Update();
Console.WriteLine(o.Position.X);
Console.Read();


Console.WriteLine("Crystal and Tool test (only Crystal):");
Crystal c = new Crystal("Crystal numero uno");
Console.WriteLine($"{c.Name}: {c.Rarity}");
Console.Read();


Console.WriteLine("Weapon and Armor test:");
Weapon w = new Weapon();
Armor a = new Armor();
Console.WriteLine($"{w.Name}: {w.Damage}");
Console.WriteLine($"{a.Name}: {a.Rating}");

Console.Read();

Console.Read();

Console.Read();

Console.Read();

Console.Read();