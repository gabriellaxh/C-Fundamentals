using System;
using System.Collections.Generic;
using System.Text;

public class DrawingTools
{
    private Square square { get; set; }
    private Rectangle rectangle { get; set; }

    public Square Square
    {
        get => this.square;
        set => this.square = value;
    }

    public Rectangle Rectangle
    {
        get => this.rectangle;
        set => this.rectangle = value;
    }

    public DrawingTools()
    {

    }

    public DrawingTools(Square square, Rectangle rectangle)
    {
        this.square = square;
        this.rectangle = rectangle;
    }
}
