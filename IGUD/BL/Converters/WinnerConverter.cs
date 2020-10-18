using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL.Converters
{
   public static class WinnerConverter
    {
        public static WinnerDTO ToDTO(Winner g)
        {
            return new WinnerDTO()
            {
                IdWin=g.IdWin,
                WinnerId=g.WinnerId,
                DateWin=g.DateWin,
                ActivityId=g.ActivityId,
                describe=g.describe
            };
        }
        public static Winner FromDTO(WinnerDTO g)
        {
            return new Winner()
            {
                IdWin=g.IdWin,
                WinnerId=g.WinnerId,
                DateWin=g.DateWin,
               ActivityId=g.ActivityId,
               describe=g.describe
            };
        }
        public static List<WinnerDTO> GetListWinnersDTO(List<Winner> lWinner)
        {
            List<WinnerDTO> l = new List<WinnerDTO>();
            lWinner.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<Winner> GetListWinnerDAL(List<WinnerDTO> lWinner)
        {
            List<Winner> l = new List<Winner>();
            lWinner.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}
