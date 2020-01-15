using System;
using System.Collections.Generic;
using System.Text;

namespace BYT11_12
{
    class LossTicket
    {
        public DateTime SubmissionDate { get; set; }
        public double Fine { get; set; }
        public LossTicket(string submissionDate, double fine)
        {
            this.SubmissionDate = DateTime.ParseExact(submissionDate, "dd/MM/yyyy", null);
            this.Fine = fine;
        }
    }
}
