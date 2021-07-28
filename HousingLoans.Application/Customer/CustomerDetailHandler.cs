using HousingLoans.Application.Customer.Dto;
using HousingLoans.Application.Customer.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace HousingLoans.Application.Customer
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerDetailHandler
    {
        private readonly ICustomerDetailRepository _customerDetailRepository;

        public CustomerDetailHandler(ICustomerDetailRepository customerDetailRepository)
        {
            _customerDetailRepository = customerDetailRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerDetailViewModel> GetAllCustomerDetails()
        {
            return from cus in _customerDetailRepository.GetCustomerDetails()
                   select new CustomerDetailViewModel()
                   {
                       CustomerId = cus.CustomerId,
                       Aid = cus.Aid,
                       UserId = cus.UserId,
                       ChtName = cus.ChtName,
                       Education = cus.Education,
                       Mobile = cus.Mobile,
                       Address = cus.Address,
                       Location = cus.Location,
                       Marry = cus.Marry,
                       Tel = cus.Tel,
                       FamilyNum = cus.FamilyNum
                   };
        }
    }
}
