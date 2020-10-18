using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL.Converters
{
    public static class SectorConverter
    {
        public static SectorDTO ToDTO(sector g)
        {
            User user = UserDAL.Get(g.UserId);
            //sector s = SectorDAL.Get(g.UserId);
            return new SectorDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                CommunityId = user.CommunityId,
                UserId = g.UserId,
                BirthDate = user.BirthDate,
                IsDeleted = user.IsDeleted,
                DeleletionDate = user.DeleletionDate,
                Street = user.Street,
                HouseNumber = user.HouseNumber,
                Phone = user.Phone,
                Sector = user.Sector,
                UserType = (eUserType)user.UserType,
               
                kind = g.kind
            };
        }

        internal static sector FromDTOPutSector(SectorDTO item)
        {
            User user = UserDAL.Get(item.UserId);
            return new sector()
            {
                kind = item.kind,
                UserId = item.UserId
            };
        }

        public static sector FromDTO(SectorDTO g)
        {
            User u = new User()
            {
                UserId = g.UserId,
                FirstName = g.FirstName,
                LastName = g.LastName,
                Email = g.Email,
                CommunityId = g.CommunityId,
                BirthDate = g.BirthDate,
                IsDeleted = g.IsDeleted,
                DeleletionDate = g.DeleletionDate,
                Street = g.Street,
                HouseNumber = g.HouseNumber,
                Phone = g.Phone,
                Sector = g.Sector,
                UserType = (int)g.UserType
            };

            return new sector()
            {
                UserId = g.UserId,
                kind = g.kind,
            
                User = u
            };
        }
        //המרה לרשימה
        public static List<SectorDTO> GetListSectorDTO(List<sector> lSector)
        {
            List<SectorDTO> l = new List<SectorDTO>();
            lSector.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<sector> GetListSectorDAL(List<SectorDTO> lSector)
        {
            List<sector> l = new List<sector>();
            lSector.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }

}

