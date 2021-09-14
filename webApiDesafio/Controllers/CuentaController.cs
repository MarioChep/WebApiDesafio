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
    [Route("[controller]")]
    public class CuentaController : ControllerBase
    {
        private readonly CuentaDBContext dBContext;
        public CuentaController(CuentaDBContext dbContext)
        {
            dBContext = dBContext;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Cuenta>> Get()
        {
            return Ok(dBContext.Cuentas.ToList());
        }
     
        [HttpPost]
        public ActionResult Post([FromBody] Cuenta cuenta)
        {
            dBContext.Cuentas.Add(cuenta);
            dBContext.SaveChanges();
            return Ok();
        }
    }
}
