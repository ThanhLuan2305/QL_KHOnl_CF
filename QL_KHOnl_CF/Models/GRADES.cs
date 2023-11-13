using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    public class GRADES
    {
        [Key]
        public string GRADEID { get; set; }
        public string ID_USER { get; set; }
        public string ID_COURSE { get; set; }
        public string ASSIGNMENTID { get; set; }
        public string QUIZID { get; set; }
        public Nullable<double> GRADE { get; set; }

        public virtual COURSE COURSE { get; set; }
        public virtual USER_COURSE USER_COURSE { get; set; }
    }
}