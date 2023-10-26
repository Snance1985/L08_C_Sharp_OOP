//CHILD
// Dog scruffy = new Dog("Scruffy", 5);
// scruffy.eat();
// scruffy.move();


//______________________________________________________________
//BREED ARGUMENT
// Dog scruffy = new Dog("Scruffy", 5, "Lab");


//______________________________________________________________
//POLYMORPHISM GENERIC ANIMAL CLASS
string GetAnimalDetails(Animal animal)
{
    return animal.AnimalName + " is of age " + animal.AnimalAge;
}

Penguin penguin = new Penguin("Sassafras", 8, false);
Dog doggo = new Dog("Rex", 4, "Labrador");

string penguinDetails = GetAnimalDetails(penguin);
string dogDetails = GetAnimalDetails(doggo);

Console.WriteLine("Penguin: " + penguinDetails);
Console.WriteLine("Dog: " + dogDetails);


void FeedAnimal(Animal animal) {
    animal.eat();
}

void MoveAnimal(Animal animal) {
    animal.move();
}

