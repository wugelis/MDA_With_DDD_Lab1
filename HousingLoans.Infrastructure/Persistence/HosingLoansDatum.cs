using System;
using System.Collections.Generic;

#nullable disable

namespace HousingLoans.Infrastructure.Persistence
{
    public partial class HosingLoansDatum
    {
        public int LoansId { get; set; }
        public string HourseOwner { get; set; }
        public string Borrower { get; set; }
        public string Industry { get; set; }
        public string LoanUsage { get; set; }
        public decimal? LoanAmount { get; set; }
        public decimal? AnnualIncome { get; set; }
        public string LocationNow { get; set; }
        public int CustomerId { get; set; }
    }
}
