using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class UserDAL
    {
        public static void Add(User item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Users.Add(item);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static void ReDelete(User user)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    User u = db.Users.Find(user.UserId);
                    u.IsDeleted = false;
                    u.DeleletionDate = null;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static void Delete(string id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    User u = db.Users.Find(id);
                    u.IsDeleted = true;
                    u.DeleletionDate = DateTime.Now;              
                    db.SaveChanges();
                }
            }
            catch(Exception exep)
            {
              
            }
        }
        public static void Put(User user)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Users.Attach(user);
                    db.Entry(user).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<User> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                 return db.Users.Where(s => s.IsDeleted == false).Where(g=>g.UserType==0).OrderBy(s => s.LastName).ToList();
               }
                catch
                {
                    throw;
                }
            }
        }
        public static List<User> GetSectors()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    return db.Users.Where(s => s.IsDeleted == false).Where(g => g.UserType == 2).OrderBy(s => s.LastName).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static  User Get(string id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.Users.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
