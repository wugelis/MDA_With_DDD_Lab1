using System;
using System.Linq;

namespace HousingLoans.Domain
{
    public class PersonalData
    {


        public string AID { get; set; }

        public string ChtName { get; set; }

        public int Marry { get; set; }

        public DateTime BirthDay { get; set; }

        private Customer Customer { get; set; }

    }
}
