using System;
using System.Collections.Generic;
using System.Text;

namespace BYT11_12
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Descritpion { get; set; }
        public string Location { get; set; }
        public string Genre { get; set; }
        public string BookStatus;
        public Book(string title, string author, string publicationDate, string description, string location, string genre, string bookStatus)
        {
            this.Title = title;
            this.Author = author;
            this.PublicationDate= DateTime.ParseExact(publicationDate, "dd/MM/yyyy", null); ;
            this.Descritpion = description;
            this.Location = location;
            this.Genre = genre;
            this.BookStatus = bookStatus;
        }
        public void SetBookStatus(string s)
        {
            if (s == "Available" || s == "Unavailable")
            {
                this.BookStatus = s;
            }
            else
            {
                Console.WriteLine("Invalid status");
            }
        }
        public string GetBookStatus()
        {
            return BookStatus;
        }

        public void SetPublicationDate(string newDate)
        {
            this.PublicationDate = DateTime.ParseExact(newDate, "dd/MM/yyyy", null); ;
        }
        public bool IsAvailable()
        {
            if (BookStatus == "Available")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
