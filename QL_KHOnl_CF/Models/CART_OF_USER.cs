﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    public class CART_OF_USER
    {
        [Key]
        public string ID_USER { get; set; }
        public string ID_COURSE { get; set; }

        public virtual USER_COURSE USER_COURSE { get; set; }
    }
}