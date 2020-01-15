using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTestProject1
{

    [TestClass]
    public class RentalTest
    {
        Rental TestRental1 = new Rental("04/01/2020", "18/01/2020", "18/01/2020");
        Rental TestRental2 = new Rental("10/01/2020", "24/01/2020", "24/01/2020");
        public Class1()
        {
        }
        [TestMethod]
        public void GetRentDateTest()
        {
            string expectedRentDate1 = DateTime.ParseExact("04/01/2020", "dd/MM/yyyy", null);
            string expectedRentDate2 = DateTime.ParseExact("10/01/2020", "dd/MM/yyyy", null);
            string actualRentDate1 = Convert.ToDateTime(TestRental1.RentDate);
            string actualRentDate2 = Convert.ToDateTime(TestRental2.RentDate);

            Assert.AreEqual(expectedRentDate1, actualRentDate1, "Something went wrong");
            Assert.AreEqual(expectedRentDate2, actualRentDate2, "Something went wrong");
        }

        [TestMethod]
        public void GetDueDateTest()
        {
            string expectedDueDate1 = DateTime.ParseExact("18/01/2020", "dd/MM/yyyy", null);
            string expectedDueDate2 = DateTime.ParseExact("24/01/2020", "dd/MM/yyyy", null);
            string actualDueDate1 = Convert.ToDateTime(TestRental1.DueDate);
            string actualDueDate2 = Convert.ToDateTime(TestRental2.DueDate);

            Assert.AreEqual(expectedDueDate1, actualDueDate1, "Something went wrong");
            Assert.AreEqual(expectedDueDate2, actualDueDate2, "Something went wrong");
        }

        [TestMethod]
        public void GetReturnDateTest()
        {
            string expectedReturnDate1 = DateTime.ParseExact("18/01/2020", "dd/MM/yyyy", null);
            string expectedReturnDate2 = DateTime.ParseExact("24/01/2020", "dd/MM/yyyy", null);
            string actualReturnDate1 = Convert.ToDateTime(TestRental1.ReturnDate);
            string actualReturnDate2 = Convert.ToDateTime(TestRental2.ReturnDate);

            Assert.AreEqual(expectedReturnDate1, actualReturnDate1, "Something went wrong");
            Assert.AreEqual(expectedReturnDate2, actualReturnDate2, "Something went wrong");
        }

        [TestMethod]
        public void SetDueDateTest()
        {
            string expectedDueDate1 = "18/01/2020";
            string expectedDueDate2 = "24/01/2020";
            TestRental1.SetDueDate(expectedDueDate1);
            TestRental2.SetDueDate(expectedDueDate2);
            string actualDueDate1 = TestRental1.GetDueDate();
            string actualDueDate2 = TestRental2.GetDueDate();

            Assert.AreEqual(expectedDueDate1, actualDueDate1, "Something went wrong");
            Assert.AreEqual(expectedDueDate2, actualDueDate2, "Something went wrong");

        }

        [TestMethod]
        public void SetReturnDateTest()
        {
            string expectedReturnDate1 = "18/01/2020";
            string expectedReturnDate2 = "24/01/2020";
            TestRental1.SetReturnDate(expectedReturnDate1);
            TestRental2.SetReturnDate(expectedReturnDate2);
            string actualReturnDate1 = TestRental1.GetReturnDate();
            string actualReturnDate2 = TestRental2.GetReturnDate();

            Assert.AreEqual(expectedReturnDate1, actualReturnDate1, "Something went wrong");
            Assert.AreEqual(expectedReturnDate2, actualReturnDate2, "Something went wrong");

        }
    }
}


