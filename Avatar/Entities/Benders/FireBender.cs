public class FireBender : Bender
{
    private float heatAggression;

    public float HeatAggression
    {
        get { return heatAggression; }
        set { heatAggression = value; }
    }

    public FireBender(string name, int power, float heatAggression) 
        : base(name, power)
    {
        this.HeatAggression = heatAggression;
    }

    public override double GetPower()
    {
        return this.Power * this.HeatAggression;
    }

    public override string ToString()
    {
        return $"Fire Bender: " + base.ToString() + $"Heat Aggression: {this.HeatAggression:f2}";
    }
}
