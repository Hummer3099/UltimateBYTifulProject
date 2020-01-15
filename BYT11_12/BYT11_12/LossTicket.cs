using System;
using System.Collections.Generic;
using System.Text;

namespace BYT11_12
{
    public class LossTicket
    {
        public DateTime SubmissionDate { get; set; }
        public double Fine { get; set; }
        public LossTicket(string submissionDate, double fine)
        {
            this.SubmissionDate = DateTime.ParseExact(submissionDate, "dd/MM/yyyy", null);
            this.Fine = fine;
        }
        public void SetSubmissionDate(string newDate)
        {
            this.SubmissionDate = DateTime.ParseExact(newDate, "dd/MM/yyyy", null); ;
        }
    }
}
