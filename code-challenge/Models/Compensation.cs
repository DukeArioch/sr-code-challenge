using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Models
{
    public class Compensation
    {
        [Key]
        public string EmployeeID { get; set; }

        public DateTime EffectiveDate { get; set; }

        public decimal Salary { get; set; }
    }
}
