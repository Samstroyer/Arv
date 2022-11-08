using System;

public class Human
{
    //The base human is Juan, 18 years old
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Human()
    {
        Name = "Juan";
        Age = 18;
    }

    public void SetValues(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void SetValues(string name)
    {
        Name = name;
    }
    public void SetValues(int age)
    {
        Age = age;
    }
}

public class Student : Human
{
    public string School { get; private set; }

    public Student()
    {
        School = "not set";
    }

    public void SetSchool(string s)
    {
        School = s;
    }
}

