using System;
using System.Collections.Generic;
using BL;
using DTO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class SchoolsController : ApiController
    {
        // GET: api/Schools
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(SchoolsBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/Schools/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                //?לעשות חיפוש דינאמי
                return Ok(SchoolsBL.GetById(id));
            }

            catch
            {
                return NotFound();
            }
        }
        // POST: api/Schools
        public IHttpActionResult Post(SchoolDTO school)
        {
            try {
                SchoolsBL.Add(school);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // PUT: api/Schools/5
        public IHttpActionResult Put(SchoolDTO school)
        {
            try {
                SchoolsBL.Update(school);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE: api/Schools/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                SchoolsBL.Delete(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

    }
}
