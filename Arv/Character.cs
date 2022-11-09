using System;

public class Character
{
    public string Name { get; set; }
    public bool? ForceSensitivity { get; set; }
    public string? ForceSide { get; set; }

    public Character(string name, bool ForceSensitivity)
    {
        Name = name;

    }
}

public class ForceUser : Character
{
    public ForceUser(string name) : base(name, true) { }
}

public class Jedi : ForceUser
{
    public Jedi(string name) : base(name)
    {
        ForceSide = "Light";
    }
}

public class Sith : ForceUser
{
    public Sith(string name) : base(name)
    {
        ForceSide = "Dark";
    }
}