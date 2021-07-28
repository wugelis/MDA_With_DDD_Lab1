using HousingLoans.Application.Customer.Repositories.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingLoans.Application.Customer.Repositories
{
    public interface ICustomerDetailRepository
    {
        IEnumerable<ICustomerDetail> GetCustomerDetails();

        void Edit(ICustomerDetail customer);

        void Add(ICustomerDetail customer);
    }
}
