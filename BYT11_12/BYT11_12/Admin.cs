using System;
using System.Collections.Generic;
using System.Text;

namespace BYT11_12
{
    class Admin : Employee
    {
        public Admin(string firstName, string surname, string dateOfBirth, string phoneNumber, string email,
        double salary, string position) : base(firstName, surname, dateOfBirth, phoneNumber, email, salary, position)
        {
        }
        public Person AddPerson(string name, string surname, string dOb, string phoneNo, string email)
        {
            return new Person(name, surname, dOb, phoneNo, email);
        }
    }
}
