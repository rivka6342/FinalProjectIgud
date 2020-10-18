using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class StudyHourDAL
    {
        public static void Add(StudyHour item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.StudyHours.Add(item);
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
                    StudyHour s = db.StudyHours.Find(id);
                    db.SignStudyHours.Remove(db.SignStudyHours.Find(id));
                    db.StudyHours.Remove(s);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Put(StudyHour studyHour)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.StudyHours.Attach(studyHour);
                    db.Entry(studyHour).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<StudyHour> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                   

                    return db.StudyHours.OrderBy(s=>s.DateStart).ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static StudyHour Get(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.StudyHours.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
