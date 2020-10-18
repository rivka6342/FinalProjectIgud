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
    public static class GuysBL
    {

        public static void Add(GuyDTO item)
        {
            User g = UserDAL.Get(item.UserId);
            if (g!= null)
            {
               
                if (g.IsDeleted == true)
                {
                    GuyDAL.ReDelete(GuyConverter.FromDTO(item));
                }
                //else
                //{
                //    //todo message user exists 
                //}
            }
            else
            GuyDAL.Add(GuyConverter.FromDTO(item));
        }

        public static void Delete(string id)
        {
            GuyDAL.Delete(id);
        }

        public static List<GuyDTO> GetAll()
        {
            var x = GuyDAL.Get();
            return GuyConverter.GetListGuyDTO(GuyDAL.Get());
        }

        public static GuyDTO GetById(string id)
        {
            return GuyConverter.ToDTO(GuyDAL.Get(id));
        }

        public static void Update(GuyDTO guy)
        {
            GuyDAL.Put(GuyConverter.FromDTO(guy));
        }

        public static List<GuyDTO> getBySchool(int idSchool)
        {
            return GuyConverter.GetListGuyDTO(GuyDAL.getBySchool(idSchool));
        }

        public static List<GuyDTO> getSmallSchool()
        {
            return GuyConverter.GetListGuyDTO(GuyDAL.getSmallSchool());
        }
        public static List<GuyDTO> getBigSchool()
        {
            return GuyConverter.GetListGuyDTO(GuyDAL.getBigSchool());
        }

        public static List<GuyDTO> getByCommunity()
        {
            return GuyConverter.GetListGuyDTO(GuyDAL.getByCommunity());
        }

        public static List<GuyDTO> getByCommunity(int id)
        {
            return GuyConverter.GetListGuyDTO(GuyDAL.getByCommunity(id));
        }

        public static List<GuyDTO> getByCommunityAndSchool(int id,int yeshivaId)
        {
            return GuyConverter.GetListGuyDTO(GuyDAL.getByCommunityAndSchool(id, yeshivaId));
        }
    }
}
