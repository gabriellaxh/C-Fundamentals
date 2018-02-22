using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get => this.length;

        set
        {
            if(value < 0)
            {
                Console.WriteLine("Length cannot be zero or negative.");
            }
            else
            {
                this.length = value;
            }
        }
    }

    public double Width
    {
        get => this.width;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Width cannot be zero or negative.");
            }
            else
            {
                this.width = value;
            }
        }
    }

    public double Height
    {
        get => this.height;
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Height cannot be zero or negative.");
            }
            else
            {
                this.height = value;
            }
        }
    }

    public Box()
    {

    }

    public Box(double length, double width, double height)
        : this()
    {
        this.length = length;
        this.width = width;
        this.height = height;
    }

    public double GetSurfaceArea(double length, double width, double height)
    {
        double surfaceArea = (2 * length * width) + (2 * length * height) + (2 * width * height);
        return surfaceArea;
    }

    public double GetLateralSurfaceArea(double length, double width, double height)
    {
        double laterSurfaceArea = (2 * length * height) + (2 * width * height);

        return laterSurfaceArea;
    }

    public double GetVolume(double length, double width, double height)
    {
        double volume = length * height * width;

        return volume;
    }

}

