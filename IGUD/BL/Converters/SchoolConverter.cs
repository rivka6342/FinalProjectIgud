using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
  public static class SchoolConverter
    {
        public static SchoolDTO ToDTO(School g)
        {
            return new SchoolDTO()
            {
               YeshivaId=g.YeshivaId,
               Name=g.Name,
               IsBig=g.IsBig,
               IsDelete=g.IsDelete,
               DeletionDate=g.DeletionDate
            };
        }
        public static School FromDTO(SchoolDTO g)
        {
            return new School()
            {
                YeshivaId = g.YeshivaId,
                Name = g.Name,
                IsBig = g.IsBig,
                IsDelete=g.IsDelete,
                DeletionDate=g.DeletionDate
            };
        }
        public static List<SchoolDTO> GetListSchoolDTO(List<School> lSchool)
        {
            List<SchoolDTO> l = new List<SchoolDTO>();
            lSchool.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<School> GetListSchoolDAL(List<SchoolDTO> lSchool)
        {
            List<School> l = new List<School>();
            lSchool.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }
}
