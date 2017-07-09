using System;

public class Mouse : Mammal
{
    public Mouse(string name, string type, double weight, string livingRegion)
        :base(livingRegion, name, type, weight)
    {
    }
    public override void MakeSound()
    {
        Console.WriteLine("SQUEEEAAAK!");
    }
    public override void Eat(Food food, int quantity)
    {
        if (food.GetType().ToString() != "Vegetable")
        {
            Console.WriteLine($"{this.GetType().ToString()}es are not eating that type of food!");
        }
    }
}