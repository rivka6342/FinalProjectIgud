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
 public   class UsersBL
    {
        public static void Add(UserDTO item)
        {
            if(UserDAL.Get(item.UserId)!=null)
            {
                if(item.IsDeleted==true)
                {
                    UserDAL.ReDelete(UserConverter.FromDTO(item));
                }
                else
                {
                    //todo message user exists 
                }
            }
            else
            UserDAL.Add(UserConverter.FromDTO(item));
        }

        public static void Delete(string id)
        {
            UserDAL.Delete(id);
        }

        public static List<UserDTO> GetAllUsers()
        {           
            return UserConverter.GetListUserDTO(UserDAL.Get());
        }
        public static List<UserDTO> GetAllSectors()
        {
            return UserConverter.GetListUserDTO(UserDAL.GetSectors());
        }
        public static UserDTO GetById(string id)
        {
            return UserConverter.ToDTO(UserDAL.Get(id));
        }

        public static void Update(UserDTO user)
        {
            UserDAL.Put(UserConverter.FromDTO(user));
        }
    }
}
