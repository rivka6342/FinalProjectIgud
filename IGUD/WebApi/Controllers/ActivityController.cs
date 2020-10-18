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
    public class ActivityController : ApiController
    {
        // GET: api/Activity
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(ActivitiesBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }
        // GET: api/Activity/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(ActivitiesBL.GetById(id));
            }
            catch
            {
                return NotFound();
            }

        }

        // POST: api/Activity
        public IHttpActionResult Post(ActiveDTO active)
        {
            try
            {
                ActivitiesBL.Add(active);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // PUT: api/Activity/5
        public IHttpActionResult Put(ActiveDTO active)
        {
            try
            {
                ActivitiesBL.Update(active);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE: api/Activity/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                ActivitiesBL.Delete(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        //public IHttpActionResult GetNumParticipants(int id)
        //{
        //    try
        //    {
        //        return Ok(ActivitiesBL.GetNumParticipants(id));
        //    }
        //    catch
        //    {
        //        return NotFound();
        //    }

        //}

    }
}
