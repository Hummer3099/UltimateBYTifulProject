using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BYT11_12;

namespace UnitTestProject1
{
    [TestClass]
    public class BookTests
    {
        Book book = new Book("Ostatnie zyczenie", "Andrzej Sapkowski", "01/01/1993","Wiedzmin","Polska","Fantasy","Available");
        [TestMethod]
        public void GetTitleTest()
        {
            string expectedTitle = "Ostatnie zyczenie";
            string actualTitle = book.Title;
            Assert.AreEqual(expectedTitle, actualTitle, "Something went wrong");
        }
        [TestMethod]
        public void GetAuthorTest()
        {
            string expectedAuthor = "Andrzej Sapkowski";
            string actualAuthor = book.Author;
            Assert.AreEqual(expectedAuthor, actualAuthor, "Something went wrong");
        }
        [TestMethod]
        public void GetPublicationDateTest()
        {
            DateTime expectedPublicationDate = DateTime.ParseExact("01/01/1993", "dd/MM/yyyy", null);
            DateTime actualPublicationDate = Convert.ToDateTime(book.PublicationDate);

            Assert.AreEqual(expectedPublicationDate, actualPublicationDate, "Something went wrong");
        }
        [TestMethod]
        public void GetDescriptionTest()
        {
            string expectedDescription = "Wiedzmin";
            string actualDescription = book.Descritpion;
            Assert.AreEqual(expectedDescription, actualDescription, "Something went wrong");
        }
        [TestMethod]
        public void GetLocationTest()
        {
            string expectedLocation = "Polska";
            string actualLocation = book.Location;
            Assert.AreEqual(expectedLocation, actualLocation, "Something went wrong");
        }
        [TestMethod]
        public void GetGenreTest()
        {
            string expectedGenre = "Fantasy";
            string actualGenre = book.Genre;
            Assert.AreEqual(expectedGenre, actualGenre, "Something went wrong");
        }
        [TestMethod]
        public void IsBookAvailablePositive()
        {
            bool expected = true;

            bool actual = book.IsAvailable();

            Assert.AreEqual(expected, actual, "Book is unavailable");
        }
        [TestMethod]
        public void IsBookUnavailable()
        {
            book.SetBookStatus("Unavailable");
            bool expected = false;

            bool actual = book.IsAvailable();

            Assert.AreEqual(expected, actual, "Book is unavailable");
        }
        [TestMethod]
        public void IsUsingCorrectStatus()
        {
            string expected = "Available";
            string actual = book.GetBookStatus();

            Assert.AreEqual(expected, actual, "Something went wrong");

            expected = "Unavailable";
            book.SetBookStatus("Unavailable");

            actual = book.GetBookStatus();

            Assert.AreEqual(expected, actual, "Something went wrong");
        }
        [TestMethod]
        public void SetTitleTest()
        {
            string expectedTitle = "Miecz Przeznaczenia";
            book.Title = expectedTitle;
            string actualTitle = book.Title;
            Assert.AreEqual(expectedTitle, actualTitle, "Something went wrong");
        }
        [TestMethod]
        public void SetAuthorTest()
        {
            string expectedAuthor = "Stanislaw Lem";
            book.Author = expectedAuthor;
            string actualAuthor = book.Author;
            Assert.AreEqual(expectedAuthor, actualAuthor, "Something went wrong");
        }
        [TestMethod]
        public void SetPublicationDateTest()
        {
            string expectedPublicationDate = ("10/10/2010");
            book.SetPublicationDate(expectedPublicationDate);
            DateTime actualPublicationDate = Convert.ToDateTime(book.PublicationDate);

            Assert.AreNotEqual(expectedPublicationDate, actualPublicationDate, "Something went wrong");
            
        }
        [TestMethod]
        public void SetDescriptionTest()
        {
            string expectedDescription = "Bohater";
            book.Descritpion = expectedDescription;
            string actualDescription = book.Descritpion;
            Assert.AreEqual(expectedDescription, actualDescription, "Something went wrong");
        }
        [TestMethod]
        public void SetLocationTest()
        {
            string expectedLocation = "Anglia";
            book.Location = expectedLocation;
            string actualLocation = book.Location;
            Assert.AreEqual(expectedLocation, actualLocation, "Something went wrong");
        }
        [TestMethod]
        public void SetGenreTest()
        {
            string expectedGenre = "Science Fiction";
            book.Genre = expectedGenre;
            string actualGenre = book.Genre;
            Assert.AreEqual(expectedGenre, actualGenre, "Something went wrong");
        }
    }
}
