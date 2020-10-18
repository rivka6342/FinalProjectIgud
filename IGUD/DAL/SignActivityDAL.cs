using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public static class SignActivityDAL
    {
        public static void Add(SignActivity item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.SignActivities.Add(item);
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
                    SignActivity s = db.SignActivities.Find(id);
                    db.SignActivities.Remove(s);

                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Put(SignActivity activity)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.SignActivities.Attach(activity);
                    db.Entry(activity).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<SignActivity> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {

                    return db.SignActivities.ToList();
                }
                catch (Exception e)
                {
                    return null;
                    //todo: add here event log writer to write the error
                }
            }
        }
        public static SignActivity Get(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.SignActivities.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

