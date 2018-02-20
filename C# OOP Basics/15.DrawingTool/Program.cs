using System;

public class Program
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();
        
        switch (figure)
        {
            case "Square":
                int side = int.Parse(Console.ReadLine());
                var square = new Square() { Side = side };
                square.Draw();
                break;

            case "Rectangle":
                int width = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                var rect = new Rectangle() { Width = width, Height = height };
                rect.Draw();
                break;
        }
    }
}

