using System;

public class Zebra : Mammal
{
    public Zebra(string name, string type, double weight, string livingRegion)
        :base(livingRegion, name, type, weight)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Zs");
    }

    public override void Eat(Food food, int quantity)
    {
        if (food.GetType().ToString() != "Vegetable")
        {
            Console.WriteLine($"{this.GetType().ToString()}s are not eating that type of food!");
        }
        else
        {
            base.Eat(food, quantity);
        }
    }
}
