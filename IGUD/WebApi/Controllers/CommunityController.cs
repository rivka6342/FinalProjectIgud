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
    public class CommunityController : ApiController
    {
        // GET: api/Community
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(CommunitiesBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/Community/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                return Ok(CommunitiesBL.GetById(id));
            }
            catch
            {
                return NotFound();
            }

        }


        // POST: api/Community
        public IHttpActionResult Post(CommunityDTO community)
        {
            try
            {
                CommunitiesBL.Add(community);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }


        // PUT: api/Community/5
        public IHttpActionResult Put(CommunityDTO community)
        {
            try { 
            CommunitiesBL.Update(community);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }


        // DELETE: api/Community/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
               CommunitiesBL.Delete(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
