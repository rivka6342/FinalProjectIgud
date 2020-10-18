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
    [RoutePrefix("api/Guys")]

    public class GuysController : ApiController
    {
        // GET: api/Guys
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(GuysBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/Guys/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                return Ok(GuysBL.GetById(id));
            }
            catch
            {
                return NotFound();
            }

        }

        // POST: api/Guys
        public IHttpActionResult Post(GuyDTO guy)
        {
            try
            {
                GuysBL.Add(guy);
                return Ok();
            }
            catch
            {
                //todo: change error message
                return NotFound();
            }
        }

        // PUT: api/Guys/5
        public IHttpActionResult Put(string id, GuyDTO guy)
        {
            try
            {
                GuysBL.Update(guy);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE: api/Guys/5
        public void Delete(string id)
        {
            GuysBL.Delete(id);
        }

        [HttpGet, Route("getBigSchool")]

        public IHttpActionResult getBigSchool()
        {
            try
            {
                return Ok(GuysBL.getBigSchool());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet, Route("getSmallSchool")]

        public IHttpActionResult getSmallSchool()
        {
            try
            {
                return Ok(GuysBL.getSmallSchool());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet, Route("getByCommunity")]
        public IHttpActionResult getByCommunity()
        {
            try
            {
                return Ok(GuysBL.getByCommunity());
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet, Route("getByCommunity/{id}")]
        public IHttpActionResult getByCommunity(int id)
        {
            try
            {
                return Ok(GuysBL.getByCommunity(id));
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet, Route("getBySchool/{id}")]
        public IHttpActionResult getBySchool(int id)
        {
            try
            {
                return Ok(GuysBL.getBySchool(id));
            }
            catch
            {
                return NotFound();
            }
        }

        //[HttpGet, Route("BySchool/{id}")]
        //public IHttpActionResult BySchool(int idSchool)
        //{
        //    try
        //    {
        //        return Ok(GuysBL.getBySchool(idSchool));
        //    }
        //    catch
        //    {
        //        return NotFound();
        //    }
        //}

        [HttpGet, Route("getByCommunityAndSchool/{id}/{yeshivaId}")]
        public IHttpActionResult getByCommunityAndSchool(int id, int yeshivaId)
        {
            try
            {
                return Ok(GuysBL.getByCommunityAndSchool(id, yeshivaId));
            }
            catch
            {
                return NotFound();
            }
        }
    }

}
