public class AirBender : Bender
{
    private float aerialIntegrity;

    public float AerialIntegrity
    {
        get { return aerialIntegrity; }
        set { aerialIntegrity = value; }
    }

    public AirBender(string name, int power, float aerialIntegrity) 
        : base(name, power)
    {
        this.AerialIntegrity = aerialIntegrity;
    }

    public override double GetPower()
    {
        return this.Power * this.AerialIntegrity;
    }

    public override string ToString()
    {
        return $"Air Bender: " + base.ToString() + $"Aerial Integrity: {this.AerialIntegrity:f2}";
    }
}
