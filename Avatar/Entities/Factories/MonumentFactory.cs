
using System.Collections.Generic;

public class MonumentFactory
{
    public Monument CreatMonument(List<string> args)
    {
        var name = args[2];
        var affinity = int.Parse(args[3]);

        switch (args[1])
        {
            case "Air":
                return new AirMonument(name, affinity);
            case "Earth":
                return new EarthMonument(name, affinity);
            case "Fire":
                return new FireMonument(name, affinity);
        }
        return new WaterMonument(name, affinity);
    }
}

