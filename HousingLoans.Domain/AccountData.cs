using System;
using System.Linq;

namespace HousingLoans.Domain
{
    public class AccountData
    {


        public string UserName { get; set; }

        public string Password { get; set; }

        private Customer Customer { get; set; }

    }
}
