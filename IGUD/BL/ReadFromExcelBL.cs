using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BL.Converters;
using DTO;
namespace BL
{
   public class ReadFromExcelBL
    {
        public static List<UserDTO> BindUser()
        {
            return ReadFromExcelConverter.GetListUserDTO(UserDAL.Get());
        }

    }
}
