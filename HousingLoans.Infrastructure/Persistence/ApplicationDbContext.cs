using HousingLoans.Application.Customer.Repositories;
using HousingLoans.Application.Customer.Repositories.IEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingLoans.Infrastructure.Persistence
{
    public class ApplicationDbContext : HosingLoansLab1DBContext, IApplicationDbContext
    {
        //DbSet<ICustomerDetail> IApplicationDbContext.CustomerDetails { get; set; }
    }
}
