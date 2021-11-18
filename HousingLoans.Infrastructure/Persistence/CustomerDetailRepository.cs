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
        private readonly ApplicationDbContext context;

        public CustomerDetailRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(ICustomerDetail customer)
        {
            context.CustomerDetails.Add(customer as CustomerDetail);
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
