using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class StudyHourDTO
    {
        public int StudyId { get; set; }
        public System.DateTime DateStart { get; set; }
        public System.DateTime DateEnd { get; set; }
        public Nullable<System.TimeSpan> TimeStart { get; set; }
        public Nullable<System.TimeSpan> TimeEnd { get; set; }
        public string tittle { get; set; }

    }
}
