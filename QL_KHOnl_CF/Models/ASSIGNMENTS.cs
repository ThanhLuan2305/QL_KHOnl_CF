using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    [Table("ASSIGNMENTS")]
    public class ASSIGNMENTS
    {
        [Key]
        public string ASSIGNMENTID { get; set; }
        public string ID_COURSE { get; set; }
        public string TITLE_ASSIGNMENT { get; set; }
        public string Description_ASSIGNMENT { get; set; }
        public Nullable<System.DateTime> DueDate_ASSIGNMENT { get; set; }
        public string Type_ASSIGNMENT { get; set; }
        public Nullable<double> POINTS { get; set; }

        public virtual COURSE COURSE { get; set; }
    }
}