using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    public class FEEDBACK
    {
        [Key]
        public string FEEDBACKID { get; set; }
        public string ID_USER { get; set; }
        public string ID_COURSE { get; set; }
        public System.DateTime DATE_FEEDBACK { get; set; }
        public string TITLE_FEEDBACK { get; set; }
        public string TEXT_FEEDBACK { get; set; }
        public Nullable<int> RATE_FEEDBACK { get; set; }

        public virtual USER_COURSE USER_COURSE { get; set; }
    }
}