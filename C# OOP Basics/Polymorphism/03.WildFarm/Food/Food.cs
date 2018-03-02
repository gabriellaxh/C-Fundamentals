public abstract class Food
{
    int quantity { get; set; }

    public Food(int quantity)
    {
        this.Quantity = quantity;
    }

    public int Quantity
    {
        get => this.quantity;
        set => this.quantity = value;
    }
}

