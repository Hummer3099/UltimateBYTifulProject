using System;

public class Employee : Person
{
    public double Salary { get; set; }
    public string Position { get; set; }
    public DateTime DateOfEmployment { get; set; }

    public Employee(string firstName, string surname, string dateOfBirth, string phoneNumber, string email,
        double salary, string position) : base(firstName, surname, dateOfBirth,
            phoneNumber, email)
    {
        this.Salary = salary;
        this.Position = position;
        this.DateOfEmployment = DateTime.Now;
    }
}
