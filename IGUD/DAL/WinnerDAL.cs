using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public static class WinnerDAL
    {
        public static void Add(Winner item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Winners.Add(item);
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
                    Winner s = db.Winners.Find(id);
                    db.Winners.Remove(s);

                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Put(Winner winner)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Winners.Attach(winner);
                    db.Entry(winner).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Winner> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {

                    return db.Winners.ToList();
                }
                catch (Exception e)
                {
                    return null;
                    //todo: add here event log writer to write the error
                }
            }
        }
        public static Winner Get(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.Winners.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
