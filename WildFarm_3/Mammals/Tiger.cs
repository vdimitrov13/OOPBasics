using System;

public class Tiger : Feline
{
    public Tiger(string name, string type, double weight, string livingRegion)
        :base(name, type, weight, livingRegion)
    {
    }
    public override void MakeSound()
    {
        Console.WriteLine("ROAAR!!!");
    }

    public override void Eat(Food food, int quantity)
    {
        if (food.GetType().ToString() != "Meat")
        {
            Console.WriteLine($"{this.GetType().ToString()}s are not eating that type of food!");
        }
        else
        {
            base.Eat(food, quantity);
        }

    }
}