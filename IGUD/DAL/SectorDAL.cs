using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
  public static class SectorDAL
    {
        public static void Add(sector item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {

                    db.sectors.Add(item);
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void AddSector(sector item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {

                    db.sectors.Add(item);
                    db.SaveChanges();
                }
            }
            catch(Exception e)
            {
                
            }
        }
        public static void Delete(string id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    sector s = db.sectors.Find(id);
                    db.sectors.Remove(s);

                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        public static void Put(sector sector)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.sectors.Attach(sector);
                    db.Entry(sector).State = EntityState.Modified;
                    db.Entry(sector.User).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public static List<sector> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    //db.Guys.Include(g => g.User).Include(g => g.YeshivaId);
                    return db.sectors.Where(s => s.User.IsDeleted == false).Where(g => g.User.UserType ==2 ).OrderBy(s => s.User.LastName).ToList();

                   // return db.sectors.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }
        public static sector Get(string id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.sectors.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
