using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ActivityDAL
    {
        public static void Add(Activity item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Activities.Add(item);
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
                    Activity s = db.Activities.Find(id);
                    db.SignActivities.Remove(db.SignActivities.Find(id));
                    db.Activities.Remove(s);

                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static int GetNumParticipants(int id)
        {
            int x=0;
            
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {


                    
                }
            }
            catch
            {
                throw;
            }
            return x;
        }

        public static void Put(Activity activity)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Activities.Attach(activity);
                    db.Entry(activity).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static List<Activity> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {


                    return db.Activities.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static Activity Get(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.Activities.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
