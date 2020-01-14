using System;

namespace BYT11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            User user1 = new User("Active");
            Console.WriteLine(user1.GetAccount_Status());
        }
    }
}
