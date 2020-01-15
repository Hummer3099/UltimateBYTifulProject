using System;
using System.Collections.Generic;
using System.Text;

namespace BYT11_12
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Descritpion { get; set; }
        public string Location { get; set; }
        public string Genre { get; set; }
        public string BookStatus { get; set; }
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
        
    }
}
