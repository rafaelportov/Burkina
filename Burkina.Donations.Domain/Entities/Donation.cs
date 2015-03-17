using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Burkina.Donations.Domain.Entities
{
    public class Donation
    {
        [Key]
        public long ID_DONATION { get; set; }

        public int ID_DONOR { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DT_DONATION { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double VL_DONATION { get; set; }
    }
}
