using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingLoans.Application.Customer.Repositories.IEntities
{
    public interface ICustomerDetail
    {
        string Aid { get; set; }
        int CustomerId { get; set; }
        string UserId { get; set; }
        string ChtName { get; set; }
        string Mobile { get; set; }
        string Education { get; set; }
        string Tel { get; set; }
        string Address { get; set; }
        string Location { get; set; }
        //string Email { get; set; }
        bool? Marry { get; set; }
        int? FamilyNum { get; set; }
    }
}
