using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class GuyDAL
    {
        public static void Add(Guy item)
        {
            try
            { 
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    
                    db.Guys.Add(item);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static void ReDelete(Guy guy)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    Guy u = db.Guys.Find(guy.UserId);
                    u.User.IsDeleted = false;
                    u.User.DeleletionDate = null;
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
                    Guy g = db.Guys.Find(id);
                    g.User.IsDeleted = true;
                    g.User.DeleletionDate = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static List<Guy> getBigSchool()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);

                    return db.Guys.Where(s => s.School.IsBig == true).Where(h=>h.User.IsDeleted==false).OrderBy(s=>s.User.LastName).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static List<Guy> getByCommunityAndSchool(int id,int  yeshivaId)
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);

                    return db.Guys.Where(s => s.User.CommunityId == id&&s.YeshivaId==yeshivaId && s.User.IsDeleted==false).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static List<Guy> getByCommunity()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);

                    return db.Guys.Where(j => j.User.IsDeleted == false).OrderBy(s => s.User.CommunityId )/*.OrderBy(u=>u.User.LastName)*/.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static List<Guy> getByCommunity(int id)
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);

                    return db.Guys.Where(s => s.User.CommunityId == id). Where(j=>j.User.IsDeleted==false).OrderBy(s=>s.User.LastName).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

       

        public static List<Guy> getSmallSchool()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);

                    return db.Guys.Where(s => s.School.IsBig==false).Where(h=>h.User.IsDeleted==false).OrderBy(s=>s.User.LastName).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static List<Guy> getBySchool(int idSchool)
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);

                    return db.Guys.Where(s => s.School.YeshivaId == idSchool && s.User.IsDeleted==false).OrderBy(s=>s.User.LastName).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// שמירת שינויים של פרטי בחור
        /// </summary>
        /// <param name="guy"></param>
        public static void Put(Guy guy)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {

                    //guy.School = null;
                    db.Guys.Attach(guy);
                    db.Entry(guy).State = EntityState.Modified;
                    db.Entry(guy.User).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public static List<Guy> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);
                    
                    return db.Guys.Where(s=>s.User.IsDeleted==false).Where(s=>s.User.UserType==1).OrderBy(s=>s.User.LastName).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static Guy Get(string id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.Guys.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
   
    }

