using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    [Table("ORDER_COURSE")]
    public class ORDER_COURSE
    {
        [Key]
        public string ID_ORDER { get; set; }
        public string ID_COURSE { get; set; }
        public string ID_USER { get; set; }
        public string STATUS_ORDER { get; set; }
        public System.DateTime TIME_AT_ORDER { get; set; }

        public virtual COURSE COURSE { get; set; }
        public virtual USER_COURSE USER_COURSE { get; set; }
    }
}