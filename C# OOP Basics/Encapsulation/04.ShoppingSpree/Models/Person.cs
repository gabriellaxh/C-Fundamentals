using System;
using System.Collections.Generic;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person()
    {

    }
    public Person(string name, decimal money, List<Product> products)
    {
        this.Name = name;
        this.Money = money;
        this.Products = products;
    }
    public string Name
    {
        get => this.name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            this.name = value;
        }
    }

    public decimal Money
    {
        get => this.money;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }
            this.money = value;
        }
    }

    public List<Product> Products
    {
        get => this.products;
        set => this.products = value;
    }
}
