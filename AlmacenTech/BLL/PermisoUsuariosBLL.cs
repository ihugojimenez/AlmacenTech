using BLL;
using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PermisoUsuariosBLL
    {

        public static List<PermisoUsuarios> GetLista()
        {
            List<PermisoUsuarios> lista = new List<PermisoUsuarios>();

            var db = new AlmacenBancasDB();

            lista = db.PermisoUsuarios.ToList();

            return lista;

        }
    }
}
