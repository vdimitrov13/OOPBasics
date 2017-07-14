
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mime;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, List<Bender>> nations;
    private Dictionary<string, List<Monument>> monuments;
    private BenderFactory benderFactory;
    private MonumentFactory monumentFactory;
    private List<string> issuedWars;
    private int counter = 1;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, List<Bender>>()
        {
            {"Air", new List<Bender>() },
            {"Fire", new List<Bender>() },
            {"Earth", new List<Bender>() },
            {"Water", new List<Bender>() }
        };
        this.monuments = new Dictionary<string, List<Monument>>()
        {
            {"Air", new List<Monument>() },
            {"Fire", new List<Monument>() },
            {"Earth", new List<Monument>() },
            {"Water", new List<Monument>() }
        };
        this.benderFactory = new BenderFactory();
        this.monumentFactory = new MonumentFactory();
        this.issuedWars = new List<string>();
    }

    public void AssignBender(List<string> benderArgs)
    {
        var newBender = benderFactory.CreateBender(benderArgs);
        this.nations[benderArgs[1]].Add(newBender);
    }
    public void AssignMonument(List<string> monumentArgs)
    {
        var newMonument = monumentFactory.CreatMonument(monumentArgs);
        this.monuments[monumentArgs[1]].Add(newMonument);
    }
    public string GetStatus(string nationsType)
    {      
        var builder = new StringBuilder();
        var nation = nations[nationsType];
        var monuments = this.monuments[nationsType];

        builder.AppendLine($"{nationsType} Nation");
        if (nation.Count > 0)
        {
            builder.AppendLine("Benders:");
            foreach (var bender in nation)
            {
                builder.AppendLine($"###{bender.ToString()}");
            }
        }
        else
        {
            builder.AppendLine("Benders: None");
        }
        if (monuments.Count > 0)
        {
            builder.AppendLine($"Monuments:");
            foreach (var monument in monuments)
            {
                builder.AppendLine($"###{monument.ToString()}");
            }
        }
        else
        {
            builder.AppendLine("Monuments: None");
        }

        return builder.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        War();
        this.issuedWars.Add($"War {counter} issued by {nationsType}");
        counter++;
    }

    private void War()
    {
        var nationsPower = new Dictionary<string, double>();
        foreach (var nation in this.nations)
        {
            var powerBeforeMonuments = nation.Value.Sum(x => x.GetPower());
            var bonusPower = (powerBeforeMonuments / 100) * (this.monuments[nation.Key].Sum(x => x.GetAffinity()));
            var totalPower = powerBeforeMonuments;

            totalPower += bonusPower;
            nationsPower.Add(nation.Key, totalPower);
        }
        var ordered = nationsPower.OrderByDescending(pair => pair.Value).ToList();
        var winner = ordered[0].Key;

        foreach (var nation in this.nations)
        {
            if (nation.Key != winner)
            {
                nation.Value.Clear();
                this.monuments[nation.Key].Clear();
            }
        }
    }

    public string GetWarsRecord()
    {
        var builder = new StringBuilder();
        foreach (var war in this.issuedWars)
        {
            builder.AppendLine(war);
        }
        return builder.ToString().Trim();
    }

}

