using System.Collections.Specialized;

public abstract class Mammal : Animal
{
    private string livingRegion;

    public Mammal(string livingRegion, string name, string type, double weight) :base(name, type, weight)
    {
        this.LivingRegion = livingRegion;
    }

    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

    public override string ToString()
    {
        return base.ToString() + $"{this.LivingRegion}, {this.FoodEaten}]";
    }
}
