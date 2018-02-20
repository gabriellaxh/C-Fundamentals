using System;
using System.Collections.Generic;
using System.Text;


public class Pokemon
{
    private string name { get; set; }
    private string element { get; set; }
    private int health { get; set; }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public string Element
    {
        get => this.element;
        set => this.element = value;
    }

    public int Health
    {
        get => this.health;
        set => this.health = value;
    }

    public Pokemon()
    {

    }

    public Pokemon(string name,string element,int health)
        :this()
    {
        this.name = name;
        this.element = element;
        this.health = health;
    }
}

