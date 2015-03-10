using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Burkina.Donations.Domain.Entities;

namespace Burkina.Donations.Domain.Repository
{
    public class CustomerRepository
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Customer> Customer
        {
            get { return _context.dsCustomer; }
        }
    }
}
