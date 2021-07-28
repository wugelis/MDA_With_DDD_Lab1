using System;
using System.Collections.Generic;
using System.Linq;

namespace HousingLoans.Domain
{
    public class Customer
    {


        public string CreatedBy { get; set; }

        public DateTime Created { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime LastModified { get; set; }

        public FamilyNum FamilyNum { get; set; }

        public Education Education { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public PersonalData Personal { get; set; }

        private List<HousingLoans> HousingLoans { get; set; }

    }
}
