namespace Inheritance;

public class Reptiles : Animal
{
    public bool IsColdBlooded { get; set; }
    public bool HasScales { get; set; }
    public bool SlowMetabolism { get; set; }
    public string DefenseType { get; set; }
    
    
    public Reptiles()
    {
        
    }

    public Reptiles(string name, int legs, bool isAlive, int age, bool isColdBlooded, bool hasScales,
        bool slowMetabolism, string defenseType)
    {
        Name = name;
        Legs = legs;
        IsAlive = isAlive;
        Age = age;
        IsColdBlooded = isColdBlooded;
        HasScales = hasScales;
        SlowMetabolism = slowMetabolism;
        DefenseType = defenseType;
    }
    
    
}