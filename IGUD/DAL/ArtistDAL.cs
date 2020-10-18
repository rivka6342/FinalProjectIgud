using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public  class ArtistDAL
    {

        public static void Add(Artist item)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Artists.Add(item);
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
                    Artist c = db.Artists.Find(id);
                    db.Artists.Remove(c);

                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {

                //todo: add here event log writer to write the error
            }
        }

        public static void Put(Artist artist)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    db.Artists.Attach(artist);
                    db.Entry(artist).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }

        public static List<Artist> Get()
        {
            using (IgudDBEntities db = new IgudDBEntities())
            {
                try
                {
                    return db.Artists.ToList();
                }
                catch (Exception e)
                {
                    return null;
                    //todo: add here event log writer to write the error
                }
            }
        }
        public static Artist Get(int id)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    return db.Artists.Find(id);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
