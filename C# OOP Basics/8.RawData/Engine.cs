using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    private int engineSpeed { get; set; }
    private int enginePower { get; set; }

    public int EngineSpeed
    {
        get => this.engineSpeed;
        set => this.engineSpeed = value;
    }

    public int EnginePower
    {
        get => this.enginePower;
        set => this.enginePower = value;
    }

    public Engine()
    {

    }
    public Engine(int engineSpeed,int enginePower)
        :this()
    {
        this.engineSpeed = engineSpeed;
        this.enginePower = enginePower;
    }

}

