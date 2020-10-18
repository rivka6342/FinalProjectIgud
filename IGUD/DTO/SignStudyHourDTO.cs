using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class SignStudyHourDTO
    {

        public int StudyHoursId { get; set; }
        public string GuyId { get; set; }
        public System.DateTime Date { get; set; }
        public int LongStudy { get; set; }
        public int StudyId { get; set; }
    }
}
