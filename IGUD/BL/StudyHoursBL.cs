using BL.Converters;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
 public   class StudyHoursBL
    {
        public static void Add(StudyHourDTO item)
        {
            StudyHourDAL.Add(StudyHourConverter.FromDTO(item));
        }

        public static void Delete(int id)
        {
            StudyHourDAL.Delete(id);
        }

        public static List<StudyHourDTO> GetAll()
        {
            return StudyHourConverter.GetListStudyHourDTO(StudyHourDAL.Get());
        }

        public static StudyHourDTO GetById(int id)
        {
            return StudyHourConverter.ToDTO(StudyHourDAL.Get(id));
        }

        public static void Update(StudyHourDTO study)
        {
            StudyHourDAL.Put(StudyHourConverter.FromDTO(study));
        }
    }
}
