using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burkina.Donations.Domain.Entities
{
    public class Donor
    {
        [Key]
        public int ID_DONOR { get; set; }
        public string DS_NAME { get; set; }
        public string DS_EMAIL { get; set; }
        public string DS_PASSWORD { get; set; }
    }
}
