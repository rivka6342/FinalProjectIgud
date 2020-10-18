using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BL.Converters;

namespace BL
{
    public static class SignActivityBL
    {
        public static void Add(SignActivityDTO item)
        {
            SignActivityDAL.Add(SignActivityConverter.FromDTO(item));
            Activity a = ActivityDAL.Get(item.ActivyId);
            a.NumSubscibers++;
            ActivityDAL.Put(a);
        }

        public static void Delete(int id)
        {
            SignActivityDAL.Delete(id);
        }

        public static List<SignActivityDTO> GetAll()
        {
            return SignActivityConverter.GetListSignActivitiesDTO(SignActivityDAL.Get());
        }

        public static SignActivityDTO GetById(int id)
        {
            return SignActivityConverter.ToDTO(SignActivityDAL.Get(id));
        }

        public static void Update(SignActivityDTO a)
        {
            SignActivityDAL.Put(SignActivityConverter.FromDTO(a));
        }
    }
}
