namespace Inheritance;

public class Bird : Animal
{
    public int Wings { get; set; }
    public string BeakType { get; set; }
    public bool HasFeathers { get; set; }
    public bool IsWarmBlooded { get; set; }

    public Bird()
    {
        
    }

    public Bird(string name, int legs, bool isAlive, int age, int wings, string beakType, bool hasFeathers,
        bool isWarmBlooded)
    {
        Name = name;
        Legs = legs;
        IsAlive = isAlive;
        Age = age;
        Wings = wings;
        BeakType = beakType;
        HasFeathers = hasFeathers;
        IsWarmBlooded = isWarmBlooded;
        

    }
}