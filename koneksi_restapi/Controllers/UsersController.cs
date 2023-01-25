using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using koneksi_restapi.models;

namespace koneksi_restapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersContext _context;

        public UsersController(UsersContext context)
        {
            this._context = context;
        }

        // GET: api/User
        [HttpGet]
        public ActionResult<IEnumerable<UserModel>> GetUsers()
        {
            _context = HttpContext.RequestServices.GetService(typeof(UsersContext)) as UsersContext;
            //return new string[] { "value1", "value2" };
            return _context.GetAllUsers();
        }

        //Get : api/user/{id}
        [HttpGet("{recid}", Name = "Get")]
        public ActionResult<IEnumerable<UserModel>> GetUserss(String recid)
        {
            _context = HttpContext.RequestServices.GetService(typeof(UsersContext)) as UsersContext;
            return _context.GetUsers(recid);
        }
    }
}
