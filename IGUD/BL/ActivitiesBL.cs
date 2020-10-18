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
 public  class ActivitiesBL
    {
        public static void Add(ActiveDTO item)
        {
            ActivityDAL.Add(ActiveConverter.FromDTO(item));
        }

        public static void Delete(int id)
        {
            ActivityDAL.Delete(id);
        }

        public static List<ActiveDTO> GetAll()
        {
            return ActiveConverter.GetListActivityDTO(ActivityDAL.Get());
        }

        public static ActiveDTO GetById(int id)
        {
            return ActiveConverter.ToDTO(ActivityDAL.Get(id));
        }

        public static void Update(ActiveDTO active)
        {
           ActivityDAL.Put(ActiveConverter.FromDTO(active));
        }

        //public static int GetNumParticipants(int id)
        //{
        //    ActivityDAL.GetNumParticipants(id);
        //}
    }
}
