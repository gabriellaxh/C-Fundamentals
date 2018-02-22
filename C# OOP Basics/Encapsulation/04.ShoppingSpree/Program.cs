using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            var people = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            var peopleList = AddPerson(people);

            var products = Console.ReadLine().Split(new[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            var productsList = AddProduct(products);

            var command = Console.ReadLine();
            while (command != "END")
            {
                var info = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var person = peopleList.FirstOrDefault(x => x.Name == info[0]);
                var product = productsList.FirstOrDefault(x => x.Name == info[1]);

                if (person != null && product != null)
                {
                    if (person.Money - product.Cost >= 0)
                    {
                        person.Money -= product.Cost;
                        person.Products.Add(product);
                        Console.WriteLine($"{person.Name} bought {product.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var person in peopleList)
            {
                if (person.Products.Count > 0)
                {
                    Console.Write($"{person.Name} - ");

                    Console.WriteLine(string.Join(", ", person.Products.Select(x => x.Name)));
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }

    public static List<Person> AddPerson(string[] people)
    {
        var peopleList = new List<Person>();

        for (int i = 0; i < people.Length; i += 2)
        {
            var person = new Person()
            {
                Name = people[i],
                Money = decimal.Parse(people[i + 1]),
                Products = new List<Product>()
            };
            peopleList.Add(person);
        }
        return peopleList;
    }

    public static List<Product> AddProduct(string[] products)
    {
        var productsList = new List<Product>();


        for (int i = 0; i < products.Length; i += 2)
        {
            var product = new Product()
            {
                Name = products[i],
                Cost = decimal.Parse(products[i + 1])
            };
            productsList.Add(product);
        }
        return productsList;
    }
}
