
using System.Collections.Generic;

public class Person
{
    private string name { get; set; }
    private Company company { get; set; }
    private Car car { get; set; }
    private List<Parent> parents { get; set; }
    private List<Child> children { get; set; }
    private List<Pokemon> pokemons { get; set; }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public Company Company
    {
        get => this.company;
        set => this.company = value;
    }

    public Car Car
    {
        get => this.car;
        set => this.car = value;
    }

    public List<Parent> Parents
    {
        get => this.parents;
        set => this.parents = value;
    }

    public List<Child> Children
    {
        get => this.children;
        set => this.children = value;
    }

    public List<Pokemon> Pokemons
    {
        get => this.pokemons;
        set => this.pokemons = value;
    }

    public Person()
    {

    }

    public Person(string name, List<Child> children, List<Pokemon> pokemons, List<Parent> parents)
    {
        this.name = name;
        this.children = new List<Child>();
        this.parents = new List<Parent>();
        this.pokemons = new List<Pokemon>();
    }
}
