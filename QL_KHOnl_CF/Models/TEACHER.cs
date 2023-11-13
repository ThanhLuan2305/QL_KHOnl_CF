using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    [Table("TEACHER")]
    public class TEACHER
    {
        [Key]
        public string ID_TEACHER { get; set; }
        public string ID_COURSE { get; set; }
        public string NAME_TEACHER { get; set; }
        public string STATUS_COURSE { get; set; }
        public string THUMBNAIL { get; set; }
        public System.DateTime D_CREATED { get; set; }
        public string LEVEL_TEACHER { get; set; }
        public string DESCRIPTION_TEACHER { get; set; }
        public virtual ICollection<COURSE> COURSE { get; set; }
    }
}