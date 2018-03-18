using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private DraftManager manager;

    public Engine()
    {
        this.manager = new DraftManager();
    }

    public void Run()
    {
        var arguments = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        while(arguments[0] != "Shutdown")
        {
            ExecuteCommand(arguments);
            arguments = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
        Console.WriteLine(this.manager.ShutDown());

    }

    
    private void ExecuteCommand(List<string> arguments)
    {
        var command = arguments[0];
        var argumentsInfo = arguments.Skip(1).ToList();

        switch (command)
        {
            case "RegisterHarvester":
                Console.WriteLine(this.manager.RegisterHarvester(argumentsInfo));
                break;

            case "RegisterProvider":
                Console.WriteLine(this.manager.RegisterProvider(argumentsInfo));
                break;

            case "Day":
                Console.WriteLine(this.manager.Day());
                break;

            case "Mode":
                Console.WriteLine(this.manager.Mode(argumentsInfo));
                break;

            case "Check":
                Console.WriteLine(this.manager.Check(argumentsInfo));
                break;
        }
    }
}

