using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QL_KHOnl_CF.Models
{
    public class QUIZZES
    {
        [Key]
        public string QUIZID { get; set; }
        public string ID_COURSE { get; set; }
        public string TITLE_QUIZID { get; set; }
        public string DESCRIPTION_QUIZID { get; set; }
        public Nullable<System.DateTime> DUEDATE_QUIZ { get; set; }
        public Nullable<int> QUESTION { get; set; }
        public Nullable<double> POINTS_QUIZ { get; set; }

        public virtual COURSE COURSE { get; set; }
    }
}