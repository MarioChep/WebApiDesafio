using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiDesafio.Models;

namespace webApiDesafio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginDBContext dBContext;
        public LoginController(LoginDBContext dbContext)
        {
            dBContext = dBContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Login>> Get()
        {
            return Ok(dBContext.Logins.ToList());
        }

        [HttpPost("login")]
        public ActionResult Post([FromBody] Login login)
        {
            dBContext.Logins.Add(login);
            dBContext.SaveChanges();
            return Ok();
        }
    }
}
