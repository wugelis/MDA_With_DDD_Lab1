using System;
using System.Linq;

namespace HousingLoans.Domain
{
    public class LoanData
    {
        public string Industry { get; set; }

        public string LoanUsage { get; set; }

        public int LoanAmount { get; set; }

        public int AnnualIncome { get; set; }

        private HousingLoans HousingLoans { get; set; }

    }
}

