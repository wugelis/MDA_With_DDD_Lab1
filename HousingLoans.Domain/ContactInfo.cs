using System;
using System.Linq;

namespace HousingLoans.Domain
{
    public class ContactInfo
    {


        public string Tel { get; set; }

        public string Address { get; set; }

        public string Location { get; set; }

        public string EMail { get; set; }

        public string Mobile { get; set; }

        private Customer Customer { get; set; }

    }
}
