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
    public static class SectorBL
    {
        public static void Add(SectorDTO item)
        {
            User g = UserDAL.Get(item.UserId);
            if (g == null)
            {
                SectorDAL.Add(SectorConverter.FromDTO(item));
            }
            else
            {
                SectorDAL.AddSector(SectorConverter.FromDTOPutSector(item));
            }
        }

        public static void Delete(string id)
        {
            SectorDAL.Delete(id);
        }

        public static List<SectorDTO> GetAll()
        {
            return SectorConverter.GetListSectorDTO(SectorDAL.Get());
        }

        public static SectorDTO GetById(string id)
        {
            return SectorConverter.ToDTO(SectorDAL.Get(id));
        }

        public static void Update(SectorDTO guy)
        {
            SectorDAL.Put(SectorConverter.FromDTO(guy));
        }
    }
}
