using System;
using System.Text;

public class Rectangle
{
    private int width { get; set; }
    private int height { get; set; }

    public int Width
    {
        get => this.width;
        set => this.width = value;
    }

    public int Height
    {
        get => this.height;
        set => this.height = value;
    }

    public Rectangle()
    { }

    public Rectangle(int width,int height)
        :this()
    {
        this.width = width;
        this.height = height;
    }

    public void Draw()
    {
        var figure = new StringBuilder();
        figure.AppendLine($"|{new string('-', width)}|");
        for (int i = 0; i < height - 2; i++)
        {
            figure.AppendLine($"|{new string(' ', width)}|");
        }
        figure.AppendLine($"|{new string('-', width)}|");
        Console.WriteLine(figure.ToString());
    }
}