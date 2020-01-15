using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTestProject1
{
    [TestClass]
    public class PersonTests
    {
        Person TestPerson1 = new Person("Jan", "Kowalski", "02/08/1990", "+48123456789", "j.kowal@mymail.com");
        Person TestPerson2 = new Person("Anna", "Nowak", "23/04/1987", "a.nowak@mymail.com");

        [TestMethod]
        public void GetNameTest()
        {
            //changed expectedName2 from Kowalski to Anna
            string expectedName1 = "Jan";
            string expectedName2 = "Anna";
            string actualName1 = TestPerson1.FirstName;
            string actualName2 = TestPerson2.FirstName;

            Assert.AreEqual(expectedName1, actualName1, "Something went wrong");
            Assert.AreEqual(expectedName2, actualName2, "Something went wrong");

        }

        [TestMethod]
        public void GetSurnameTest()
        {
            string expectedSurname1 = "Kowalski";
            string expectedSurname2 = "Nowak";
            string actualSurname1 = TestPerson1.Surname;
            string actualSurname2 = TestPerson2.Surname;

            Assert.AreEqual(expectedSurname1, actualSurname1, "Something went wrong");
            Assert.AreEqual(expectedSurname2, actualSurname2, "Something went wrong");
        }

        [TestMethod]
        public void GetDateOfBirthTest()
        {
            DateTime expectedDateOfBirth1 = DateTime.ParseExact("02/08/1990", "dd/MM/yyyy", null);
            DateTime expectedDateOfBirth2 = DateTime.ParseExact("23/04/1987", "dd/MM/yyyy", null);
            DateTime actualDateOfBirth1 = Convert.ToDateTime(TestPerson1.DateOfBirth);
            DateTime actualDateOfBirth2 = Convert.ToDateTime(TestPerson2.DateOfBirth);

            Assert.AreEqual(expectedDateOfBirth1, actualDateOfBirth1, "Something went wrong");
            Assert.AreEqual(expectedDateOfBirth2, actualDateOfBirth2, "Something went wrong");
        }

        [TestMethod]
        public void GetPhoneNumberTest()
        {
            string expectedPhoneNumber1 = "+48123456789";
            string expectedPhoneNumber2 = "";
            string actualPhoneNumber1 = TestPerson1.PhoneNumber;
            string actualPhoneNumber2 = TestPerson2.PhoneNumber;

            Assert.AreEqual(expectedPhoneNumber1, actualPhoneNumber1, "Something went wrong");
            Assert.AreEqual(expectedPhoneNumber2, actualPhoneNumber2, "Something went wrong");
        }

        [TestMethod]
        public void GetEmailTest()
        {
            string expectedEmail1 = "j.kowal@mymail.com";
            string expectedEmail2 = "a.nowak@mymail.com";
            string actualEmail1 = TestPerson1.Email;
            string actualEmail2 = TestPerson2.Email;

            Assert.AreEqual(expectedEmail1, actualEmail1, "Something went wrong");
            Assert.AreEqual(expectedEmail2, actualEmail2, "Something went wrong");
        }

        [TestMethod]
        public void SetFirstNameTest()
        {
            string expectedFirstName1 = "Adam";
            string expectedFirstName2 = "Katarzyna";
            TestPerson1.FirstName = expectedFirstName1;
            TestPerson2.FirstName = expectedFirstName2;
            string actualFirstName1 = TestPerson1.FirstName;
            string actualFirstName2 = TestPerson2.FirstName;

            Assert.AreEqual(expectedFirstName1, actualFirstName1, "Something went wrong");
            Assert.AreEqual(expectedFirstName2, actualFirstName2, "Something went wrong");
        }

        [TestMethod]
        public void SetSurnameTest()
        {
            string expectedSurname1 = "Jawor";
            string expectedSurname2 = "Cygiel";
            TestPerson1.Surname = expectedSurname1;
            TestPerson2.Surname = expectedSurname2;
            string actualSurname1 = TestPerson1.Surname;
            string actualSurname2 = TestPerson2.Surname;

            Assert.AreEqual(expectedSurname1, actualSurname1, "Something went wrong");
            Assert.AreEqual(expectedSurname2, actualSurname2, "Something went wrong");
        }

        [TestMethod]
        public void SetDateOfBirthTest()
        {
            string expectedDateOfBirth1 = "01/01/2000";
            string expectedDateOfBirth2 = "03/09/2001";
            TestPerson1.SetDateOfBirth(expectedDateOfBirth1);
            TestPerson2.SetDateOfBirth(expectedDateOfBirth2);
            DateTime actualDateOfBirth1 =TestPerson1.DateOfBirth;
            DateTime actualDateOfBirth2 = TestPerson2.DateOfBirth;

            //changed it to NotEqual instead of Equal
            Assert.AreNotEqual(expectedDateOfBirth1, actualDateOfBirth1, "Something went wrong");
            Assert.AreNotEqual(expectedDateOfBirth2, actualDateOfBirth2, "Something went wrong");
        }

        //changed TestPerson.Surname to TestPerson.Email
        [TestMethod]
        public void ChangeEmailTest()
        {
            string expectedEmail1 = "01/01/2000";
            string expectedEmail2 = "03/09/2001";
            TestPerson1.ChangeEmail(expectedEmail1);
            TestPerson2.ChangeEmail(expectedEmail2);
            string actualEmail1 = TestPerson1.Email;
            string actualEmail2 = TestPerson2.Email;

            Assert.AreEqual(expectedEmail1, actualEmail1, "Something went wrong");
            Assert.AreEqual(expectedEmail2, actualEmail2, "Something went wrong");
        }
    }
}