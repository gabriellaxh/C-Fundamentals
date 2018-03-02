using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Smartphone : ICall, IBrowse
{
    private List<string> phoneNumbers;
    private List<string> sites;
    
    public Smartphone(List<String> phoneNumbers, List<String> sites)
    {
        this.PhoneNumbers = phoneNumbers;
        this.Sites = sites;
    }

    public List<string> PhoneNumbers
    {
        get => this.phoneNumbers;
        set
        {
            foreach (var number in value)
            {
                if (number.ToCharArray().Any(x => !char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    this.phoneNumbers = value;
                    Console.WriteLine($"Calling... {number}");
                }
            }
        }
    }

    public List<string> Sites
    {
        get => this.sites;
        set
        {
            foreach (var site in value)
            {
                if (site.ToCharArray().Any(x => char.IsDigit(x)))
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    this.sites = value;
                    Console.WriteLine($"Browsing: {site}!");
                }
            }
        }
    }
}

