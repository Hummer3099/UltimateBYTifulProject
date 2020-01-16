using System;
using System.Text;
using System.Collections.Generic;

public class Rental
{
    public DateTime RentDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnDate { get; set; }

    public Rental(DateTime dueDate, DateTime returnDate)
    {
        this.RentDate = DateTime.ParseExact(rentDate, "dd/MM/yyyy", null);
        this.DueDate = DateTime.ParseExact(dueDate, "dd/MM/yyyy", null);
        this.ReturnDate = DateTime.ParseExact(returnDate, "dd/MM/yyyy", null);
    }

    public void ChangeReturnDate(DateTime newReturnDate)
    {
        this.ReturnDate = DateTime.ParseExact(newReturnDate, "dd/MM/yyyy", null);
    }
    public void GetReturnDate()
    {
        return ReturnDate;
    }

    public void GetDueDate()
    {
        return DueDate;
    }
    public void GetRentDate()
    {
        return RentDate;
    }

    public void SetRentDate(string newDate)
    {
        this.RentDate = DateTime.ParseExact(newDate, "dd/MM/yyyy", null);
    }
    public void SetDueDate(string newDate)
    {
        this.DueDate = DateTime.ParseExact(newDate, "dd/MM/yyyy", null);
    }
    public void SetReturnDate(string newDate)
    {
        this.ReturnDate = DateTime.ParseExact(newDate, "dd/MM/yyyy", null);
    }
}
