public class WaterBender : Bender
{
    private float waterClarity;

    public float WaterClarity
    {
        get { return waterClarity; }
        set { waterClarity = value; }
    }

    public WaterBender(string name, int power, float waterClarity) 
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }

    public override double GetPower()
    {
        return this.Power * this.WaterClarity;
    }

    public override string ToString()
    {
        return $"Water Bender: " + base.ToString() + $"Water Clarity: {this.WaterClarity:f2}";
    }
}
