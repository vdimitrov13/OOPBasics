
using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        var command = Console.ReadLine();

        while (command != "Quit")
        {
            var inputArgs = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            GetShitDone(inputArgs.ToList());

            command = Console.ReadLine();
        }
        Console.WriteLine(nationsBuilder.GetWarsRecord());
        
    }

    public void GetShitDone(List<string> args)
    {
        switch (args[0])
        {
            case "Bender":              
                nationsBuilder.AssignBender(args);
                break;
            case "Monument":
                nationsBuilder.AssignMonument(args);
                break;
            case "Status":
                Console.WriteLine(nationsBuilder.GetStatus(args[1]));            
                break;
            case "War":
                nationsBuilder.IssueWar(args[1]);
                break;
        }
    }
}

