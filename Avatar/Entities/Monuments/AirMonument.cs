public class AirMonument : Monument
{
    private int airAffinity;


    public int AirAffinity
    {
        get { return airAffinity; }
        set { airAffinity = value; }
    }

    public AirMonument(string name, int affinity) : base(name)
    {
        this.AirAffinity = affinity;
    }

    public override string ToString()
    {
        return $"Air Monument: {this.Name}, Air Affinity: {this.AirAffinity}";
    }

    public override int GetAffinity()
    {
        return this.AirAffinity;
    }
}
