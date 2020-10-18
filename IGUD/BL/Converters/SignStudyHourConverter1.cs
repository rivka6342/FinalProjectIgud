using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
  public  class SignStudyHourConverter1
    {
        public static SignStudyHourDTO ToDTO(SignStudyHour g)
        {
            return new SignStudyHourDTO()
            {
                StudyHoursId = g.StudyHoursId,
                GuyId = g.GuyId,
                Date = g.Date,
                LongStudy = g.LongStudy,
                StudyId = g.StudyId
            };
        }
        public static SignStudyHour FromDTO(SignStudyHourDTO g)
        {
            return new SignStudyHour()
            {

                StudyHoursId = g.StudyHoursId,
                GuyId = g.GuyId,
                Date = g.Date,
               LongStudy=g.LongStudy,
                StudyId = g.StudyId
            };
        }
        public static List<SignStudyHourDTO> GetListSignStudyHourDTO(List<SignStudyHour> lSignStudyHour)
        {
            List<SignStudyHourDTO> l = new List<SignStudyHourDTO>();
            lSignStudyHour.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<SignStudyHour> GetListSignStudyHourDAL(List<SignStudyHourDTO> lSignStudyHour)
        {
            List<SignStudyHour> l = new List<SignStudyHour>();
            lSignStudyHour.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}

