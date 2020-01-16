using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTestProject1
{

    [TestClass]
    public class RentalTest
    {
        Rental TestRental = new Rental("04/01/2020", "18/01/2020", "18/01/2020");
              
        [TestMethod]
        public void SetRentDateTest()
        {
            string expectedRentDate = ("04/01/2020");
            TestRental1.SetRentDate(expectedRentDate1);
            DateTime actualRentDate = Convert.ToDateTime(TestRental.RentDate);

            Assert.AreEqual(expectedRentDate, actualRentDate, "Something went wrong");
         }

        [TestMethod]
        public void SetDueDateTest()
        {
            string expectedDueDate = ("18/01/2020");
            TestRental.SetDueDate(expectedDueDate1);
            DateTime actualDueDate = Convert.ToDateTime(TestRental.DueDate);

            Assert.AreEqual(expectedDueDate, actualDueDate, "Something went wrong");
        }

        [TestMethod]
        public void SetReturnDateTest()
        {
            string expectedReturnDate = ("18/01/2020");
            TestRental.SetReturnDate(expectedReturnDate1);
            DateTime actualReturnDate = Convert.ToDateTime(TestRental.ReturnDate);

            Assert.AreEqual(expectedReturnDate, actualReturnDate, "Something went wrong");
        }

       [TestMethod]
       public void GetRentDateTest()
        {
            DateTime expectedRentDate = DateTime.ParseExact("04/01/2020", "dd/MM/yyyy", null);
            DateTime acutalRentDate = Convert.ToDateTime(TestRental.RentDate);

            Assert.AreEqual(expectedRentDate, actualRentDate, "Something went wrong");
        }
        [TestMethod]
        public void GetReturnDateTest()
        {
            DateTime expectedReturnDate = DateTime.ParseExact("18/01/2020", "dd /MM/yyyy", null);
            DateTime acutalReturnDate = Convert.ToDateTime(TestRental.ReturnDate);

            Assert.AreEqual(expectedReturnDate, actualReturnDate, "Something went wrong");
        }

        [TestMethod]
        public void GetRDueDateTest()
        {
            DateTime expectedDueDate = DateTime.ParseExact("18/01/2020", "dd /MM/yyyy", null);
            DateTime acutalDueDate = Convert.ToDateTime(TestRental.DueDate);

            Assert.AreEqual(expectedDueDate, actualDueDate, "Something went wrong");
        }
    }
}


