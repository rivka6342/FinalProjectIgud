using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BL.Converters
{
  public static class ReadFromExcelConverter
    {
        public static UserDTO ToDTO(User g)
        {
            Community c = CommunityDAL.Get(g.CommunityId);
            return new UserDTO()
            {
                CommunityId = g.CommunityId,
                Email = g.Email,
                FirstName = g.FirstName,
                LastName = g.LastName,
                UserId = g.UserId,
                UserType = (eUserType)g.UserType,
                BirthDate = g.BirthDate,
                IsDeleted = g.IsDeleted,
                DeleletionDate = g.DeleletionDate,
                Street = g.Street,
                HouseNumber = g.HouseNumber,
                Phone = g.Phone,
                Sector = g.Sector,
                CommunityName = c.CommunityName
            };
        }

        public static User FromDTO(UserDTO g)
        {
            return new User()
            {

                CommunityId = g.CommunityId,
                Email = g.Email,
                FirstName = g.FirstName,
                LastName = g.LastName,
                UserId = g.UserId,
                UserType = (int)g.UserType,
                BirthDate = g.BirthDate,
                DeleletionDate = g.DeleletionDate,
                IsDeleted = g.IsDeleted,
                Street = g.Street,
                HouseNumber = g.HouseNumber,
                Phone = g.Phone,
                Sector = g.Sector
            };
        }
        public static List<UserDTO> GetListUserDTO(List<User> lUser)
        {
            List<UserDTO> l = new List<UserDTO>();
            lUser.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<User> GetListUserDAL(List<UserDTO> lUser)
        {
            List<User> l = new List<User>();
            lUser.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}

