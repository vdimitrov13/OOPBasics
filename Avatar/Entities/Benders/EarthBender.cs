public class EarthBender : Bender
{
    private float groundSaturation;

    public float GroundSaturation
    {
        get { return groundSaturation; }
        set { groundSaturation = value; }
    }

    public EarthBender(string name, int power, float groundSaturation) 
        : base(name, power)
    {
        this.GroundSaturation = groundSaturation;
    }

    public override double GetPower()
    {
        return this.Power * this.GroundSaturation;
    }

    public override string ToString()
    {
        return $"Earth Bender: " + base.ToString() + $"Ground Saturation: {this.GroundSaturation:f2}";
    }
}
