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
    public class ArtistController : ApiController
    {
        // GET: api/Artist
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(ArtistBL.GetAll());
            }
            catch
            {
                return NotFound();
            }
        }
        // GET: api/Artist/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                //?לעשות חיפוש דינאמי
                return Ok(ArtistBL.GetById(id));
            }

            catch
            {
                return NotFound();
            }
        }
        // POST: api/Artist
        public IHttpActionResult Post(ArtistDTO artist)
        {
            try
            {
                ArtistBL.Add(artist);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // PUT: api/Artist/5
        public IHttpActionResult Put(ArtistDTO artist)
        {
            try
            {
                ArtistBL.Update(artist);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // DELETE: api/Artist/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                ArtistBL.Delete(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
