using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    [Table("CART_OF_USER")]
    public class CART_OF_USER
    {
        [Key]
        public string ID_USER { get; set; }
        public string ID_COURSE { get; set; }

        public virtual USER_COURSE USER_COURSE { get; set; }
    }
}