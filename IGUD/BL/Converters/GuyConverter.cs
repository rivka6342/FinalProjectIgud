using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Converters
{
    public static class GuyConverter
    {
        public static GuyDTO ToDTO(Guy g)
        {
            User user = UserDAL.Get(g.UserId);
            School s = SchoolDAL.Get(g.YeshivaId);
            Community c = CommunityDAL.Get(user.CommunityId);
            return new GuyDTO()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                CommunityId = user.CommunityId,
               CommunityName=c.CommunityName,
                UserId = g.UserId,
                YeshivaId = g.YeshivaId,
                YeshivaName = s.Name,
                IsBig = s.IsBig,
                BirthDate = user.BirthDate,
                IsDeleted = user.IsDeleted,
                DeleletionDate = user.DeleletionDate,
                Lesson = g.Lesson,
                Street = user.Street,
                HouseNumber = user.HouseNumber,
                Phone = user.Phone,
                Sector = user.Sector,
                UserType = (eUserType)user.UserType
            };
        }

        public static Guy FromDTO(GuyDTO g)
        {
            School school = SchoolDAL.Get(g.YeshivaId);
            School s;
            if (school != null)
            {
                s = new School()
                {
                    YeshivaId = school.YeshivaId,
                    Name = school.Name,
                    IsBig = school.IsBig
                };
            }
            else
            {
                throw new System.ArgumentException("ישיבה לא קיימת");
            }
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
                UserType =(int)g.UserType
            };

            return new Guy()
            {
                UserId = g.UserId,
                YeshivaId = g.YeshivaId,
                Lesson = g.Lesson,
                User = u,
                School = s
            };
        }
        //המרה לרשימה
        public static List<GuyDTO> GetListGuyDTO(List<Guy> lGuy)
        {
            List<GuyDTO> l = new List<GuyDTO>();
            lGuy.ForEach(w => l.Add(ToDTO(w)));
            return l;
        }
        public static List<Guy> GetListGuyDAL(List<GuyDTO> lGuy)
        {
            List<Guy> l = new List<Guy>();
            lGuy.ForEach(w => l.Add(FromDTO(w)));
            return l;
        }
    }

}
