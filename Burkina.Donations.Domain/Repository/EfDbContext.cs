using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Burkina.Donations.Domain.Entities;

namespace Burkina.Donations.Domain.Repository
{
    public class EfDbContext : DbContext
    {
        public DbSet<Donor> dsDonor { get; set; }
        public DbSet<Donation> dsDonation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            //modelbuilder.Entity<Donor>().ToTable("Donors");
            modelbuilder.Entity<Donation>().ToTable("Donations");
            /*modelbuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelbuilder.Entity<Customer>().ToTable("tbCustomers");*/
        }
    }


}
