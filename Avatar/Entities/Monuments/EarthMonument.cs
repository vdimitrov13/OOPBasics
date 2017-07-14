public class EarthMonument : Monument
{
    private int earthAffinity;

    public int EarthAffinity
    {
        get { return earthAffinity; }
        set { earthAffinity = value; }
    }

    public EarthMonument(string name, int affinity) : base(name)
    {
        this.EarthAffinity = affinity;
    }

    public override string ToString()
    {
        return $"Earth Monument: {this.Name}, Earth Affinity: {this.EarthAffinity}";
    }

    public override int GetAffinity()
    {
        return this.EarthAffinity;
    }
}

