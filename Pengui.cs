//POLYMORPHISM
public class Penguin : Animal
{
    public bool flies;

    public Penguin(string name, int age, bool canFly)
    {
        animalName = name;
        animalAge = age;
        flies = canFly;
    }

    public bool CanFly
    {
        get { return flies; }
        set { flies = value; }
    }

    public override void eat()
    {
        Console.WriteLine(animalName + " is eating some fish!");
    }

    public override void move() {
        Console.WriteLine(animalName + " is swimming through the water!");
    }
}



//______________________________________________________________
//
