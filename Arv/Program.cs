//Assignment on inheritance - Samuel Palmér TE20A
//All classes relating to the same assignment are in the same file

using System.Numerics;

Console.WriteLine("Student test:");
Student s = new Student();
Console.WriteLine("Name: " + s.Name + "\nAge: " + s.Age + "\nSchool: " + s.School);
Console.ReadKey();
Console.Clear();

Console.WriteLine("Moving Object test:");
MovingObject o = new MovingObject();
o.Velocity = new Vector2(1, 0);
Console.WriteLine(o.Position.X);
o.Update();
Console.WriteLine(o.Position.X);
o.Update();
o.Update();
Console.WriteLine(o.Position.X);
Console.ReadKey();
Console.Clear();


Console.WriteLine("Crystal and Tool test (only Crystal):");
Crystal c = new Crystal("Crystal numero uno");
Console.WriteLine($"{c.Name}: {c.Rarity}");
Console.ReadKey();
Console.Clear();


Console.WriteLine("Weapon and Armor test:");
Weapon w = new Weapon();
Armor a = new Armor();
Console.WriteLine($"{w.Name}: {w.Damage}");
Console.WriteLine($"{a.Name}: {a.Rating}");
Console.ReadKey();
Console.Clear();


Jedi j = new Jedi("Yoda");
Console.WriteLine($"{j.Name}: {j.ForceSide}");
Console.ReadKey();
Console.Clear();


Avatar avatar = new Avatar();
PoisonPotion p = new PoisonPotion();
Console.WriteLine(avatar.Hitpoints);
p.Use(avatar);
Console.WriteLine(avatar.Hitpoints);
Console.ReadKey();
Console.Clear();


Teleporter t = new Teleporter();
Console.WriteLine(t.Position.X + "  " + t.Position.Y);
t.Update();
t.Update();
t.Update();
t.Update();
t.Update();
Console.WriteLine(t.Position.X + "  " + t.Position.Y);
Console.ReadKey();
Console.Clear();


LootBoxStore store = new LootBoxStore();
Console.WriteLine("Opening box 3");
store.Open(3);
Console.WriteLine("\nOpening box 5");
store.Open(5);
Console.WriteLine("\nOpening box 10");
store.Open(10);
Console.WriteLine("\nChoose a box to open:");
store.Open();
Console.ReadKey();
Console.Clear();