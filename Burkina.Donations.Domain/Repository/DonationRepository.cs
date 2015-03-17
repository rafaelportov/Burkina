using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Burkina.Donations.Domain.Entities;

namespace Burkina.Donations.Domain.Repository
{
    public class DonationRepository
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Donation> Donation
        {
            get { return _context.dsDonation; }
        }
    }
}
