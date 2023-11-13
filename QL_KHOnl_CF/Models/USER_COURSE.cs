using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    public class USER_COURSE
    {
        [Key]
        public string ID_USER { get; set; }
        public string FULLNAME_USER { get; set; }
        public int NUMBER_OF_COURSE { get; set; }
        public string EMAIL_USER { get; set; }
        public string PHONE_USER { get; set; }
        public string ROLE_USER { get; set; }
        public string STATUS_USER { get; set; }
        public virtual ICollection<CART_OF_USER> CART_OF_USER { get; set; }
        public virtual ICollection<FEEDBACK> FEEDBACK { get; set; }
        public virtual ICollection<GRADES> GRADES { get; set; }
        public virtual ICollection<ORDER_COURSE> ORDER_COURSE { get; set; }
    }
}