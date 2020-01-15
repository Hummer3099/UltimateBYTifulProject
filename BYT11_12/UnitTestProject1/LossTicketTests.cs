using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT11_12;

namespace UnitTestProject1
{
    [TestClass]
    public class LossTicketTests
    {
        LossTicket lossTicket = new LossTicket("16/04/2020", 2077);
        [TestMethod]
        public void GetSubmissionDateTest()
        {
            DateTime expectedSubmissionDate = DateTime.ParseExact("16/04/2020", "dd/MM/yyyy", null);
            DateTime actualSubmissionDate = Convert.ToDateTime(lossTicket.SubmissionDate);

            Assert.AreEqual(expectedSubmissionDate, actualSubmissionDate, "Something went wrong");
        }
        [TestMethod]
        public void GetFineTest()
        {
            double expectedFine = 2077;
            double actualFine = lossTicket.Fine;
            Assert.AreEqual(expectedFine, actualFine, "Something went wrong");
        }
        [TestMethod]
        public void SetSetSubmissionDateTest()
        {
            string expectedSubmissionDate = ("01/01/2020");  
            lossTicket.SetSubmissionDate(expectedSubmissionDate);
            DateTime actualSubmissionDate = Convert.ToDateTime(lossTicket.SubmissionDate);

            Assert.AreNotEqual(expectedSubmissionDate, actualSubmissionDate, "Something went wrong");
        }
        [TestMethod]
        public void SetFineTest()
        {
            double expectedFine = 1337;
            lossTicket.Fine = expectedFine;
            double actualFine = lossTicket.Fine;
            Assert.AreEqual(expectedFine, actualFine, "Something went wrong");
        }
    }
}
