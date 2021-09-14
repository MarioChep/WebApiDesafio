using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webApiDesafio.Models
{
    public class CuentaDBContext: DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public CuentaDBContext()
        {

        }
        public CuentaDBContext(DbContextOptions options): base(options)
        {

        }
    }
}
