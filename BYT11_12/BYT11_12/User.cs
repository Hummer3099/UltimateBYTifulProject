using System;
using System.Collections.Generic;
using System.Text;

namespace BYT11_12
{
    public class User : Person
    {
        private string Account_Status;

        public User(string firstName, string surname, string dateOfBirth, string phoneNumber, string email, string status) : base(firstName, surname, dateOfBirth, phoneNumber, email)
        {
            SetAccount_Status(status);
        }
        public void SetAccount_Status(string s)
        {
            if(s == "Active" || s == "Deactivated")
            {
                this.Account_Status = s;
            }
            else
            {
                Console.WriteLine("Invalid status");
            }
        }
        public string GetAccount_Status()
        {
            return Account_Status;
        }

        public bool IsActive()
        {
            if(Account_Status == "Active")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*public List<Rentals> GetRentals()
       {
            //search through the list and find matching rentals
       }*/
    }
}
