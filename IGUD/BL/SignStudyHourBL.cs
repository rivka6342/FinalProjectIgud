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
   public class SignStudyHourBL
    {
        public static void Add(SignStudyHourDTO item)
        {
            SignstudyHourDAL.Add(SignStudyHourConverter1.FromDTO(item));
        }

        public static void Delete(int id)
        {
            SignstudyHourDAL.Delete(id);
        }

        public static List<SignStudyHourDTO> GetAll()
        {
            return SignStudyHourConverter1.GetListSignStudyHourDTO(SignstudyHourDAL.Get());
        }

        public static SignStudyHourDTO GetById(int id)
        {
            return SignStudyHourConverter1.ToDTO(SignstudyHourDAL.Get(id));
        }

        public static void Update(SignStudyHourDTO study)
        {
            SignstudyHourDAL.Put(SignStudyHourConverter1.FromDTO(study));
        }
    }
}

