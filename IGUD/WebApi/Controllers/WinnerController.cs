using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DTO;
using BL;
namespace WebApi.Controllers
{
    public class WinnerController : ApiController
    {
        // GET: api/Winner
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(WinnerBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }


        // GET: api/Winner/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                //?לעשות חיפוש דינאמי
                return Ok(WinnerBL.GetById(id));
            }

            catch
            {
                return NotFound();
            }
        }

        // POST: api/Winner
        public IHttpActionResult Post(WinnerDTO winner)
        {
            try
            {
               WinnerBL.Add(winner);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // PUT: api/Winner/5
        public IHttpActionResult Put(WinnerDTO winner)
        {
            try
            {
                WinnerBL.Update(winner);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // DELETE: api/Winner/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                WinnerBL.Delete(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
