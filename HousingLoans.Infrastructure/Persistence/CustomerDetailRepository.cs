using HousingLoans.Application.Customer.Repositories;
using HousingLoans.Application.Customer.Repositories.IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingLoans.Infrastructure.Persistence
{
    public class CustomerDetailRepository: ICustomerDetailRepository
    {
        private readonly HosingLoansLab1DBContext context;

        public CustomerDetailRepository(HosingLoansLab1DBContext context)
        {
            this.context = context;
        }

        public void Add(ICustomerDetail customer)
        {
            throw new NotImplementedException();
        }

        public void Edit(ICustomerDetail customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ICustomerDetail> GetCustomerDetails()
        {
            return context.CustomerDetails.ToList();
        }
    }
}
