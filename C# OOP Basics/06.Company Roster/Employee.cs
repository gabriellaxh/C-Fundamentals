public class Employee
{
    private string name { get; set; }
    private decimal salary { get; set; }
    private string position { get; set; }
    private string department { get; set; }
    private string email { get; set; }
    private int age { get; set; }

    public Employee()
    {
        this.email = "n/a";
        this.age = -1;
    }

    public Employee(string name, decimal salary, string position, string department)
        :this()
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;

    }
   
    public Employee(string name, decimal salary, string position, string department, int age)
        : this(name, salary, position, department)
    {
        this.age = age;
    }

    public Employee(string name, decimal salary, string position, string department, string email)
       : this(name, salary, position, department)
    {
        this.email = email;
    }

    public Employee(string name, decimal salary, string position, string department, string email, int age)
       : this(name, salary, position, department)
    {
        this.email = email;
        this.age = age;
    }

    public string Name
    {
        get => this.name;
        set => this.name = value;
    }

    public decimal Salary
    {
        get => this.salary;
        set => this.salary = value;
    }

    public string Position
    {
        get => this.position;
        set => this.position = value;
    }

    public string Department
    {
        get => this.department;
        set => this.department = value;
    }

    public string Email
    {
        get => this.email;
        set => this.email = value;
    }

    public int Age
    {
        get => this.age;
        set => this.age = value;
    }
}


