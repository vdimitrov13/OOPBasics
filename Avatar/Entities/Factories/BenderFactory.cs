
using System.Collections.Generic;

public class BenderFactory
{
    public Bender CreateBender(List<string> args)
    {
        var name = args[2];
        var power = int.Parse(args[3]);
        var secondary = float.Parse(args[4]);
        switch (args[1])
        {
            case "Air":
                return new AirBender(name, power, secondary);
            case "Earth":
                return new EarthBender(name, power, secondary);
            case "Fire":
                return new FireBender(name, power, secondary);
        }
        return new WaterBender(name, power, secondary);
    }
}

