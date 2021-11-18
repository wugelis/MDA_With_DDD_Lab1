using HousingLoans.Application.Customer;
using HousingLoans.Application.Customer.Repositories;
using HousingLoans.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebHousingLoansApp.Models;

namespace WebHousingLoansApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HosingLoansLab1DBContext _context;
        private readonly ICustomerDetailRepository _customerDetailRepository;

        public HomeController(
            ILogger<HomeController> logger, 
            HosingLoansLab1DBContext context, 
            ICustomerDetailRepository customerDetailRepository)
        {
            _logger = logger;
            this._context = context;
            this._customerDetailRepository = customerDetailRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult CustomerDetailList()
        {
            CustomerDetailHandler customerDetailHandler = new CustomerDetailHandler(_customerDetailRepository);

            var result = customerDetailHandler.GetAllCustomerDetails();

            return View(result);
        }
    }
}
