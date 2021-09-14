using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace webApiDesafio.Models
{
    public class LoginDBContext : DbContext
    {
        public DbSet<Cuenta> Cuentas { get; set; }
        public LoginDBContext()
        {

        }
        public LoginDBContext(DbContextOptions options): base(options)
        {

        }
    }
}
