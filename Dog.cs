//INHERITANCE EXAMPLE

//INHERITED CLASS
// public class Dog : Animal
// {
//     // Default constructor
//     public Dog()
//     {
//         animalName = "";
//         animalAge = 0;
//     }

//     // Parameterized constructor
//     public Dog(string name, int age)
//     {
//         animalName = name;
//         animalAge = age;
//     }
// }


//______________________________________________________________
//BASE () 
// public class Dog : Animal
// {
//     // Default constructor
//     public Dog() : base()
//     {
//     }

//     // Parameterized constructor
//     public Dog(string name, int age) : base(name, age)
//     {
//     }
// }


//______________________________________________________________
//GETTER AMD SETTER PROPERTY
public class Dog : Animal
{
    protected string? breedName;

    public Dog() : base()
    {
    }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        breedName = breed;
    }

    public string? BreedName
    {
        get { return breedName; }
        set { breedName = value; }
    }

    //______________________________________________________________
    //OVERRIDE
    public override void eat()
    {
        Console.WriteLine(animalName + " is chomping down its dog food!");
    }

    public override void move()
    {
        Console.WriteLine(animalName + " is running and wagging its tail!");
    }

}



