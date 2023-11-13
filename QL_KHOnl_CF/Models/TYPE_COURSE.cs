using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    public class TYPE_COURSE
    {
        [Key]
        public string ID_TYPECOURSE { get; set; }
        public string NAME_TYPECOURSE { get; set; }
        public string THUMBNAIL { get; set; }
        public virtual ICollection<COURSE> COURSE { get; set; }
    }
}
