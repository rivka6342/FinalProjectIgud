using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
   public static class StudyHourConverter
    {
        public static StudyHourDTO ToDTO(StudyHour s)
        {
            return new StudyHourDTO()
            {
               StudyId=s.StudyId,
               DateStart=s.DateStart,
               DateEnd=s.DateEnd,
               TimeStart=s.TimeStart,
               TimeEnd=s.TimeEnd,
               tittle=s.tittle
            };
        }

        public static StudyHour FromDTO(StudyHourDTO s)
        {
            return new StudyHour()
            {
                StudyId = s.StudyId,
                DateStart = s.DateStart,
                DateEnd = s.DateEnd,
                TimeStart = s.TimeStart,
                TimeEnd = s.TimeEnd,
                tittle=s.tittle
            };
        }
        public static List<StudyHourDTO> GetListStudyHourDTO(List<StudyHour> lStudyHour)
        {
            List<StudyHourDTO> l = new List<StudyHourDTO>();
            lStudyHour.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<StudyHour> GetListStudyHourDAL(List<StudyHourDTO> lStudyHour)
        {
            List<StudyHour> l = new List<StudyHour>();
            lStudyHour.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}

