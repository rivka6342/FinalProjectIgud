using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
   public class CommunityConverter
    {
        public static CommunityDTO ToDTO(Community c)
        {
            return new CommunityDTO()
            {
               CommunityId=c.CommunityId,
               CommunityName=c.CommunityName,
               Street=c.Street,
               HouseNumber=c.HouseNumber,
               City=c.City,
               RavName=c.RavName,
               delitiondate=c.delitiondate,
               IsDelete=c.IsDelete
            };
        }
        public static Community FromDTO(CommunityDTO c)
        {
            return new Community()
            {
                CommunityId = c.CommunityId,
                CommunityName = c.CommunityName,
                Street = c.Street,
                HouseNumber = c.HouseNumber,
                City = c.City,
                RavName = c.RavName,
                IsDelete=c.IsDelete,
                delitiondate=c.delitiondate
            };
        }
        public static List<CommunityDTO> GetListCommunityDTO(List<Community> lCommunity)
        {
            List<CommunityDTO> l = new List<CommunityDTO>();
            lCommunity.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<Community> GetListCommunityDAL(List<CommunityDTO> lCommunity)
        {
            List<Community> l = new List<Community>();
            lCommunity.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}
