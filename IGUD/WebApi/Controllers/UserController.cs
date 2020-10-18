using BL;
using DTO;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        // GET: api/User
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(UsersBL.GetAllUsers());
            }
            catch
            {
                return NotFound();
            }
        }

        // GET: api/User/5
        //public IHttpActionResult Get(string id)
        //{
        //    try
        //    {
        //        return Ok(UsersBL.GetById(id));
        //    }
        //    catch
        //    {
        //        return NotFound();
        //    }

        //}

        [HttpPost, Route("Login")]
        public IHttpActionResult Login(object userId)
        {
            try
            {
                var user = JObject.Parse(userId.ToString());
                var password = user["Password"].ToString();
                UserDTO u = UsersBL.GetById(password);
                switch (u.UserType)
                {
                    case eUserType.Coordinator:
                        return Ok(u);
                    case eUserType.Guy:
                        return Ok(GuysBL.GetById(password));
                    case eUserType.Sector:
                        return Ok(SectorBL.GetById(password));
                    case eUserType.Manager:
                        return Ok(u);
                    default:
                        return NotFound();
                }
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // POST: api/User
        public IHttpActionResult Post(UserDTO user)
        {
            try
            {
                UsersBL.Add(user);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }

        // PUT: api/User/5
        public IHttpActionResult Put(UserDTO user)
        {
            try
            {
                UsersBL.Update(user);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
        // DELETE: api/User/5
        public void Delete(string id)
        {
            UsersBL.Delete(id);
        }
    }
}
