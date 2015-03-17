using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Burkina.Donations.Domain.Repository;
using Burkina.Donations.Domain.Entities;

namespace Burkina.Donations.Web.Controllers
{
    public class DonationController : Controller
    {
        private DonationRepository _repository;
        // GET: Donation

        public ActionResult DonationsTotal()
        {
            _repository = new DonationRepository();
            var donation = _repository.Donation;
            return View(donation.ToList());
        }
    }
}