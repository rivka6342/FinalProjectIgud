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
    public class SignStudyHourController : ApiController
    {
        // GET: api/SignStudyHour
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(SignStudyHourBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/SignStudyHour/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(SignStudyHourBL.GetById(id));
            }
            catch
            {
                return NotFound();
            }

        }

        // POST: api/SignStudyHour
        public IHttpActionResult Post(SignStudyHourDTO SignStudyHour)
        {
            try
            {
                SignStudyHourBL.Add(SignStudyHour);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // PUT: api/SignStudyHour/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SignStudyHour/5
        public void Delete(int id)
        {
        }
    }
}
