using System;
using System.Linq;

namespace HousingLoans.Domain
{
	public class HousingLoans
	{
		public string HouseOwner { get; set; }

		public string LocationNow { get; set; }

		public string Borrower { get; set; }

		private Customer Customer { get; set; }

		private LoanData LoanData { get; set; }

	}
}
