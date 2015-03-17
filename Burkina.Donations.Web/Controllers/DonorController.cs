using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Burkina.Donations.Domain.Repository;

namespace Burkina.Donations.Web.Controllers
{
    public class DonorController : Controller
    {
        private DonorRepository _repository;
        // GET: Donor
        public ActionResult Doadores()
        {
            _repository = new DonorRepository();
            var donor = _repository.Donor;
            return View(donor);
        }
    }
}