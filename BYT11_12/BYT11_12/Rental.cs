using System;

public class Rental
{
    public DateTime RentDate { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReturnDate { get; set; }

    public Rental(DateTime dueDate, DateTime returnDate)
    {
        this.RentDate = DateTime.Now;
        this.DueDate = DateTime.ParseExact(dueDate, "dd/MM/yyyy", null);
        this.ReturnDate = DateTime.ParseExact(returnDate, "dd/MM/yyyy", null);
    }

    public void ChangeReturnDate(DateTime newReturnDate)
    {
        this.ReturnDate = DateTime.ParseExact(newReturnDate, "dd/MM/yyyy", null);
    }
}
