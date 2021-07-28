using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingLoans.Application.Customer.Dto
{
    public class CustomerDetailViewModel
    {
        public int CustomerId { get; set; }
        public string ChtName { get; set; }
        public string Aid { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public bool? Marry { get; set; }
        public int? FamilyNum { get; set; }
        public string Education { get; set; }
        public string UserId { get; set; }
        public int SerialNumber { get; set; }
    }
}
