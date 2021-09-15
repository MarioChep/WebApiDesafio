using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webApiDesafio.Models;

namespace webApiDesafio.Repo
{
    public class RPData
    {
        public static List<Cuenta> _listaCuentas = new List<Cuenta>()
        {
            new Cuenta() { Usuario = "1", Email ="usuario1@tesst.cl", Nombre = "Cliente 1" , Apellido = "Apellido 1", Password="" },
            new Cuenta() { Usuario = "2", Email ="usuario2@tesst.cl", Nombre = "Cliente 2" , Apellido = "Apellido 2", Password="" },
            new Cuenta() { Usuario = "3", Email ="usuario1@tesst.cl" ,Nombre = "Cliente 3" , Apellido = "Apellido 3", Password="" }
        };

        public IEnumerable<Cuenta> ObtenerCuenta()
        {
            return _listaCuentas;
        }

        public Cuenta ObtenerCuenta(string usuario)
        {
            var cuenta = _listaCuentas.Where(cli => cli.Usuario == usuario);

            return cuenta.FirstOrDefault();
        }

        public void Agregar(Cuenta nuevaCuenta)
        {
            _listaCuentas.Add(nuevaCuenta);
        }
    }
}
}
