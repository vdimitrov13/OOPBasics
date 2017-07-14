public class FireMonument : Monument
{
    private int fireAffinity;

    public int FireAffinity
    {
        get { return fireAffinity; }
        set { fireAffinity = value; }
    }

    public FireMonument(string name, int affinity) : base(name)
    {
        this.FireAffinity = affinity;
    }

    public override string ToString()
    {
        return $"Fire Monument: {this.Name}, Fire Affinity: {this.FireAffinity}";
    }

    public override int GetAffinity()
    {
        return this.FireAffinity;
    }
}
