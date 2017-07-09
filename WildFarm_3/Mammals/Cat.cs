using System;

public class Cat : Feline
{
    private string breed;

    public Cat(string name, string type, double weight, string livingRegion, string breed)
        :base(name, type, weight, livingRegion)
    {
        this.Breed = breed;
    }

    public string Breed
    {
        get { return breed; }
        set { breed = value; }
    }

    public override void MakeSound()
    {
        Console.WriteLine("Meowwww");
    }

    public override string ToString()
    {
        return $"{this.GetType().ToString()}[{this.AnimalName}, {this.breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
