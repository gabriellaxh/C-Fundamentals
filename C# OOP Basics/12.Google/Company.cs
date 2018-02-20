using System;
using System.Collections.Generic;
using System.Text;

public class Company
{
    private string companyName { get; set; }
    private string department { get; set; }
    private decimal salary { get; set; }

    public string CompanyName
    {
        get => this.companyName;
        set => this.companyName = value;
    }

    public string Department
    {
        get => this.department;
        set => this.department = value;
    }

    public decimal Salary
    {
        get => this.salary;
        set => this.salary = value;
    }

    public Company()
    {

    }

    public Company(string companyName, string department, decimal salary)
        :this()
    {
        this.companyName = companyName;
        this.department = department;
        this.salary = salary;
    }
}

