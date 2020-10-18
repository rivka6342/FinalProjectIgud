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
  public  class CommunitiesBL
    {
        public static void Add(CommunityDTO item)
        {
            CommunityDAL.Add(CommunityConverter.FromDTO(item));
        }     

        public static void Delete(int id)
        {
            CommunityDAL.Delete(id);
        }

        public static List<CommunityDTO> GetAll()
        {
            return CommunityConverter.GetListCommunityDTO(CommunityDAL.Get());
        }

        public static CommunityDTO GetById(int id)
        {
            return CommunityConverter.ToDTO(CommunityDAL.Get(id));
        }

        public static void Update(CommunityDTO community)
        {
            CommunityDAL.Put(CommunityConverter.FromDTO(community));
        }       
    }
}
