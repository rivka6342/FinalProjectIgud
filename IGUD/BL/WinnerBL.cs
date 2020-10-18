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
   public static class WinnerBL
    {
        public static void Add(WinnerDTO item)
        {
           WinnerDAL.Add(WinnerConverter.FromDTO(item));
        }

        public static void Delete(int id)
        {
            WinnerDAL.Delete(id);
        }

        public static List<WinnerDTO> GetAll()
        {
            return WinnerConverter.GetListWinnersDTO(WinnerDAL.Get());
        }

        public static WinnerDTO GetById(int id)
        {
            return WinnerConverter.ToDTO(WinnerDAL.Get(id));
        }

        public static void Update(WinnerDTO winner)
        {
           WinnerDAL.Put(WinnerConverter.FromDTO(winner));
        }
    }
}
