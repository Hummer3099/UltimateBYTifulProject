using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT11_12;

namespace UnitTestProject1
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void IsUserActivePositive()
        {
            bool expected = true;
            User user = new User("Active");

            bool actual = user.IsActive();

            Assert.AreEqual(expected, actual, "Account not active");
        }
        [TestMethod]
        public void IsUserDeactivated()
        {
            bool expected = false;
            User user = new User("Deactivated");

            bool actual = user.IsActive();

            Assert.AreEqual(expected, actual, "Account not active");
        }
        [TestMethod]
        public void IsUsingCorrectStatus()
        {
            string expected = "Active";
            User user = new User("Active");

            string actual = user.GetAccount_Status();

            Assert.AreEqual(expected, actual, "Something went wrong");

            expected = "Deactivated";
            user.SetAccount_Status("Deactivated");

            actual = user.GetAccount_Status();

            Assert.AreEqual(expected, actual, "Something went wrong");
        }
    }
}
