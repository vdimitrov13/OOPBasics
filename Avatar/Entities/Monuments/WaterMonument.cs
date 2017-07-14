public class WaterMonument : Monument
{
    private int waterAffinity;

    public int WaterAffinity
    {
        get { return waterAffinity; }
        set { waterAffinity = value; }
    }

    public WaterMonument(string name, int affinity) : base(name)
    {
        this.WaterAffinity = affinity;
    }

    public override string ToString()
    {
        return $"Water Monument: {this.Name}, Water Affinity: {this.WaterAffinity}";
    }

    public override int GetAffinity()
    {
        return this.WaterAffinity;
    }
}
