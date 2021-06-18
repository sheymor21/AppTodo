using Microsoft.AspNetCore.Mvc;
using Database;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System;

namespace RestApiTo_do.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DBcontext db = new DBcontext();

        private readonly ILogger<UsersController> _logger;
        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Users> GetAll()
        {
            return db.users.OrderBy(b => b.usersId).ToList();
        }

        [HttpGet("ID")]
        public IActionResult Get(int ID)
        {
            var list = db.users.FirstOrDefault((p) => p.usersId == ID);
            if (list == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(list);
            }
        }

        [HttpPost]
        public IActionResult Post(Users us)
        {
            try
            {
                db.Add(new Users
                {
                    name = us.name,
                    fecha = us.fecha,
                    email = us.email,
                    username = us.username
                });
                db.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        [HttpDelete("ID")]
        public IActionResult Delete(int ID)
        {
            Users user = db.users.FirstOrDefault((p) => p.usersId == ID);
            if (user == null)
            {
                return NotFound();
            }
            else
            {

                db.Remove(user);
                db.SaveChanges();
                return Ok();
            }
        }

    }
}
