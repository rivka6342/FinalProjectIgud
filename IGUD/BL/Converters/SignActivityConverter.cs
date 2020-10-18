using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BL.Converters
{
   public static class SignActivityConverter
    {
        public static SignActivityDTO ToDTO(SignActivity g)
        {
            return new SignActivityDTO()
            {
               ActivyId=g.ActivyId,
               GuyId=g.GuyId
               //,
              // SignActivityID=g.SignActivityID
            };
        }
        public static SignActivity FromDTO(SignActivityDTO g)
        {
            return new SignActivity()
            {
               ActivyId=g.ActivyId,
               GuyId=g.GuyId
               //,
              // SignActivityID=g.SignActivityID              
            };
        }
        public static List<SignActivityDTO> GetListSignActivitiesDTO(List<SignActivity> lActivity)
        {
            List<SignActivityDTO> l = new List<SignActivityDTO>();
            lActivity.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<SignActivity> GetListSignActivitiyDAL(List<SignActivityDTO> lSignActivity)
        {
            List<SignActivity> l = new List<SignActivity>();
            lSignActivity.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}
