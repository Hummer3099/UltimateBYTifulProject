using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT11_12;

namespace UnitTestProject1
{
    [TestClass]
    public class UserTests
    {
        User user = new User("Lee", "Everett","21/05/1997", "545218141", "sth@goo.com" , "Active");
        [TestMethod]
        public void IsUserActivePositive()
        {
            bool expected = true;

            bool actual = user.IsActive();

            Assert.AreEqual(expected, actual, "Account not active");
        }
        [TestMethod]
        public void IsUserDeactivated()
        {
            user.SetAccount_Status("Deactivated");
            bool expected = false;

            bool actual = user.IsActive();

            Assert.AreEqual(expected, actual, "Account not active");
        }
        [TestMethod]
        public void IsUsingCorrectStatus()
        {
            string expected = "Active";
            string actual = user.GetAccount_Status();

            Assert.AreEqual(expected, actual, "Something went wrong");

            expected = "Deactivated";
            user.SetAccount_Status("Deactivated");

            actual = user.GetAccount_Status();

            Assert.AreEqual(expected, actual, "Something went wrong");
        }
    }
}
