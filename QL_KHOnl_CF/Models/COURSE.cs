using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    [Table("COURSE")]
    public class COURSE
    {
        [Key]
        public string ID_COURSE { get; set; }
        public string ID_TYPECOURSE { get; set; }
        public string ID_TEACHER { get; set; }
        public string NAME_COURSE { get; set; }
        public string DESCRIPTION_COURSE { get; set; }
        public double PRICE_COURSE { get; set; }
        public string STATUS_COURSE { get; set; }
        public string THUMBNAIL { get; set; }
        public int COUNT_LESSON_COURSE { get; set; }
        public string LEVEL_COURSE { get; set; }
        public Nullable<System.DateTime> CREATED_AT_COURSE { get; set; }
        public Nullable<System.DateTime> UPDATE_AT_COURSE { get; set; }
        public virtual ICollection<ASSIGNMENTS> ASSIGNMENTS { get; set; }
        public virtual TEACHER TEACHER { get; set; }
        public virtual TYPE_COURSE TYPE_COURSE { get; set; }
        public virtual ICollection<GRADES> GRADES { get; set; }
        public virtual ICollection<QUIZZES> QUIZZES { get; set; }
        public virtual ICollection<ORDER_COURSE> ORDER_COURSE { get; set; }
    }
}