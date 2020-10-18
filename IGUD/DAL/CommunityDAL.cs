using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class CommunityDAL
    {


        public static void Add(Community item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Communities.Add(item);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static void ReDelete(Community community)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    Community s = db.Communities.Find(community.CommunityId);
                    s.IsDelete = false;
                    s.delitiondate = null;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static void Delete(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    Community s = db.Communities.Find(id);
                    s.IsDelete = true;
                    s.delitiondate = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception exep)
            {
                //todo: add here event log writer to write the error
            }
        }
      
        public static void Put(Community community)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Communities.Attach(community);
                    db.Entry(community).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }      

        public static List<Community> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    return db.Communities.ToList();
                }
                catch (Exception e)
                {
                    return null;
                    //todo: add here event log writer to write the error
                }
            }
        }
        public static Community Get(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.Communities.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
