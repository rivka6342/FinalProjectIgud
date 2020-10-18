using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class SignstudyHourDAL
    {
        public static void Add(SignStudyHour item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.SignStudyHours.Add(item);
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
                    SignStudyHour s = db.SignStudyHours.Find(id);
                    db.SignStudyHours.Remove(s);

                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Put(SignStudyHour SignStudyHour)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.SignStudyHours.Attach(SignStudyHour);
                    db.Entry(SignStudyHour).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<SignStudyHour> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {


                    return db.SignStudyHours.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static SignStudyHour Get(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.SignStudyHours.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

