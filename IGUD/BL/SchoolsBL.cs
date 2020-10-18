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
    public static class SchoolsBL
    {
        
        public static void Add(SchoolDTO item)
        {
            SchoolDAL.Add(SchoolConverter.FromDTO(item));
        }

        public static void Delete(int id)
        {
            SchoolDAL.Delete(id);
        }

        public static List<SchoolDTO> GetAll()
        {
            return SchoolConverter.GetListSchoolDTO(SchoolDAL.Get());
        }

        public static SchoolDTO GetById(int id)
        {
            return SchoolConverter.ToDTO(SchoolDAL.Get(id));
        }

        public static void Update(SchoolDTO guy)
        {
            SchoolDAL.Put(SchoolConverter.FromDTO(guy));
        }
    }
    }
