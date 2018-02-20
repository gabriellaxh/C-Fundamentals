using System;
using System.Text;

public class Square
{
    private int side { get; set; }

    public int Side
    {
        get => this.side;
        set => this.side = value;
    }

    public Square()
    { }

    public Square(int side)
            : this()
    {
        this.side = side;
    }

    public void Draw()
    {
        var figure = new StringBuilder();
        figure.AppendLine($"|{new string('-', side)}|");
        for (int i = 0; i < this.side - 2; i++)
        {
            figure.AppendLine($"|{new string(' ', side)}|");
        }
        figure.AppendLine($"|{new string('-', side)}|");
        Console.WriteLine(figure.ToString());
    }
}