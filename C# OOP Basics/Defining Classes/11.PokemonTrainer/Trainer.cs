using System;
using System.Collections.Generic;
using System.Text;

public class Trainer
{
    private string name { get; set; }
    private int badges { get; set; }
    private ICollection<Pokemon> pokemons = new List<Pokemon>();

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public int Badges
    {
        get => this.badges;
        set => this.badges = value;
    }

    public ICollection<Pokemon> Pokemons
    {
        get => this.pokemons;
        set => this.pokemons = value;
    }

    public Trainer()
    {
        badges = 0;
    }

    public Trainer(string name, int badges, ICollection<Pokemon> pokemons)
        :this()
    {
        this.name = name;
        this.badges = badges;
        this.pokemons = pokemons;
    }
}