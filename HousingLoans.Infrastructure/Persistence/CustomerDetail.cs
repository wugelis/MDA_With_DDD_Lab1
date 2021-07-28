using HousingLoans.Application.Customer.Repositories.IEntities;
using System;
using System.Collections.Generic;

#nullable disable

namespace HousingLoans.Infrastructure.Persistence
{
    public partial class CustomerDetail: ICustomerDetail
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
    }
}
