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
    public class SignActivityController : ApiController
    {
        // GET: api/SignActivity
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(SignActivityBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/SignActivity/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(SignActivityBL.GetById(id));
            }
            catch
            {
                return NotFound();
            }

        }
        // POST: api/SignActivity
        public IHttpActionResult Post(SignActivityDTO SignActivity)
        {
            try
            {
                SignActivityBL.Add(SignActivity);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // PUT: api/SignActivity/5
        public IHttpActionResult Put(SignActivityDTO SignActivity)
        {
            try
            {
               SignActivityBL.Update(SignActivity);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }


        // DELETE: api/SignActivity/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                SignActivityBL.Delete(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
