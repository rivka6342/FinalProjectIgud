using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BL;
using DTO;

namespace WebApi.Controllers
{
    public class SectorController : ApiController
    {
        // GET: api/Sector
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(UsersBL.GetAllSectors());
            }
            catch(Exception e)
            {
                return NotFound();
            }
        }
        // GET: api/Sector/5
        public IHttpActionResult Get(string id)
        {
            try
            {
                return Ok(UsersBL.GetById(id));
            }
            catch
            {
                return NotFound();
            }

        }
        // POST: api/Sector
        public IHttpActionResult Post(UserDTO sector)
        {
            try
            {
                UsersBL.Add(sector);
                return Ok();
            }
            catch
            {
                //todo: change error message
                return NotFound();
            }
        }


        // PUT: api/Sector/5
        public IHttpActionResult Put(string id, UserDTO sector)
        {
            try
            {
                UsersBL.Update(sector);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }


        // DELETE: api/Sector/5
        public void Delete(string id)
        {
            UsersBL.Delete(id);
        }
    }
}
