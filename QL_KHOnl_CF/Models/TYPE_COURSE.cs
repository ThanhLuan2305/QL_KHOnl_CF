using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    [Table("TYPE_COURSE")]
    public class TYPE_COURSE
    {
        [Key]
        public string ID_TYPECOURSE { get; set; }
        public string NAME_TYPECOURSE { get; set; }
        public string THUMBNAIL { get; set; }
        public virtual ICollection<COURSE> COURSE { get; set; }
    }
}
