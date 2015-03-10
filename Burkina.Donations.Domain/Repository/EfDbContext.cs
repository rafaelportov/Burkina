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
        public DbSet<Customer> dsCustomer { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Customer>().ToTable("tbCustomers");
            /*modelbuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelbuilder.Entity<Customer>().ToTable("tbCustomers");*/
        }
    }


}
