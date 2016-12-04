using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ORCA2.Models
{
    public class Expert
    {
        [Key]
        public int ExpertID { get; set; }//44444
        public int ExpertiseID { get; set; }
        public Boolean Validated { get; set; }
    }
}