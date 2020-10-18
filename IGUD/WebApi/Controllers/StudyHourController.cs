using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class StudyHourController : ApiController
    {
        // GET: api/StudyHour
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(StudyHoursBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }


        // GET: api/StudyHour/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(StudyHoursBL.GetById(id));
            }
            catch
            {
                return NotFound();
            }

        }

        // POST: api/StudyHour
        public void Post(StudyHourDTO StudyHour)
        {
            StudyHoursBL.Add(StudyHour);
        }

        // PUT: api/StudyHour/5
        public void Put(StudyHourDTO StudyHour)
        {
            StudyHoursBL.Update(StudyHour);
        }

        // DELETE: api/StudyHour/5
        public void Delete(int id)
        {
            StudyHoursBL.Delete(id);
        }
    }
}
