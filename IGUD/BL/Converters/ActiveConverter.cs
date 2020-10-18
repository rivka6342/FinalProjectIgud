using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
  public static class ActiveConverter
    {
        public static ActiveDTO ToDTO(Activity g)
        {
            return new ActiveDTO()
            {
                ActiveId = g.ActiveId,
                Date=g.Date,
                Describe=g.Describe,
                ArtistId=g.ArtistId,
                NumSubscibers=g.NumSubscibers,
                 Prepay=g.Prepay,
                 tittle=g.tittle
            };
        }

        public static Activity FromDTO(ActiveDTO g)
        {
            return new Activity()
            {
                ActiveId = g.ActiveId,
                Date = g.Date,
                Describe = g.Describe,
                ArtistId = g.ArtistId,
                NumSubscibers = g.NumSubscibers,
                Prepay=g.Prepay,
                tittle=g.tittle
            };
        }
        public static List<ActiveDTO> GetListActivityDTO(List<Activity> lActivity)
        {
            List<ActiveDTO> l = new List<ActiveDTO>();
            lActivity.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<Activity> GetListActivityDAL(List<ActiveDTO> lActivity)
        {
            List<Activity> l = new List<Activity>();
            lActivity.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}

