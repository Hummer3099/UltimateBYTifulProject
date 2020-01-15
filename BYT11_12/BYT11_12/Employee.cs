using System;

public class Employee : Person
{
    public double Salary { get; set; }
    public string Position { get; set; }
    public DateTime DateOfEmployment { get; set; }

    public Employee(double salary, string position)
    {
        this.Salary = salary;
        this.Position = position;
        this.DateOfEmployment = DateTime.Now;
    }
}
