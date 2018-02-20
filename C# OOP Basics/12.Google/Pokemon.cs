public class Pokemon
{
    private string pokemonName { get; set; }
    private string pokemonType { get; set; }

    public string PokemonName
    {
        get => this.pokemonName;
        set => this.pokemonName = value;
    }

    public string PokemonType
    {
        get => this.pokemonType;
        set => this.pokemonType = value;
    }

    public Pokemon()
    {

    }
    public Pokemon(string pokemonName, string pokemonType)
        :this()
    {
        this.pokemonName = pokemonName;
        this.pokemonType = pokemonType;
    }
}

