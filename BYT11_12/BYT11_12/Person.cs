using System;

public class Person
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public Person(string firstName, string surname, string dateOfBirth, string phoneNumber, string email)       //date format "05/05/2005"
    {
        this.FirstName = firstName;
        this.Surname = surname;
        this.DateOfBirth = DateTime.ParseExact(dateOfBirth, "dd/MM/yyyy", null); ;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
    }

    public Person()
    { 
    }

    public Person(string firstName, string surname, string dateOfBirth, string email)
    {
        this.FirstName = firstName;
        this.Surname = surname;
        this.DateOfBirth = DateTime.ParseExact(dateOfBirth, "dd/MM/yyyy", null);
        this.PhoneNumber = "";
        this.Email = email;
    }

    public void ChangeEmail(string newEmail)
    {
        this.Email = newEmail;
    }

    public void SetDateOfBirth(string newDate)
    {
        this.DateOfBirth = DateTime.ParseExact(newDate, "dd/MM/yyyy", null); ;
    }
}
