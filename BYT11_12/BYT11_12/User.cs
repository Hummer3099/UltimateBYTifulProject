using System;
using System.Collections.Generic;
using System.Text;

namespace BYT11_12
{
    public class User
    {
        //Person person;
        private string Account_Status;

        public User(string accounts)
        {
            //Add Person whenever the Person class is ready
            SetAccount_Status(accounts);
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
