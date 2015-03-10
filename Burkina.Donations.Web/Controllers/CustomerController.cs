using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Burkina.Donations.Domain.Repository;

namespace Burkina.Donations.Web.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerRepository _repository;
        // GET: Customer
        public ActionResult Index()
        {
            _repository = new CustomerRepository();
            var customer = _repository.Customer;
            return View(customer);
        }
    }
}