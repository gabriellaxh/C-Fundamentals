using System;

public class Program
{
    static void Main(string[] args)
    {
        var length = double.Parse(Console.ReadLine());
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());

        var newBox = new Box()
        {
            Length = length,
            Width = width,
            Height = height
        };

        Console.WriteLine($"Surface Area - {newBox.GetSurfaceArea(length, width, height):f2}");
        Console.WriteLine($"Lateral Surface Area - {newBox.GetLateralSurfaceArea(length, width, height):f2}");
        Console.WriteLine($"Volume - {newBox.GetVolume(length, width, height):f2}");

    }
}

