using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class SchoolDAL
    {

            public static void Add(School item)
            {
                try
                {
                    using (IgudDBEntities db = new IgudDBEntities())
                    {
                        db.Schools.Add(item);
                        db.SaveChanges();
                    }
                }
                catch
                {
                    throw;
                }
            }
        public static void ReDelete(School school)
        {
            try
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    School s = db.Schools.Find(school.YeshivaId);
                    s.IsDelete= false;
                    s.DeletionDate = null;
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
                    School s = db.Schools.Find(id);
                    s.IsDelete = true;
                    s.DeletionDate = DateTime.Now;
                    db.SaveChanges();
                }
            }
            catch (Exception exep)
            {

            }
        }
            public static void Put(School school)
            {
                try
                {
                    using (IgudDBEntities db = new IgudDBEntities())
                    {
                        db.Schools.Attach(school);
                        db.Entry(school).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                catch
                {
                    throw;
                }
            }
            public static List<School> Get()
            {
                using (IgudDBEntities db = new IgudDBEntities())
                {
                    try
                    {

                        return db.Schools.ToList();
                    }
                      catch(Exception e)
                    {
                    return null;
                    //todo: add here event log writer to write the error
                }
                }
            }
            public static School Get(int id)
            {
                try
                {
                    using (IgudDBEntities db = new IgudDBEntities())
                    {
                        return db.Schools.Find(id);
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
    }
