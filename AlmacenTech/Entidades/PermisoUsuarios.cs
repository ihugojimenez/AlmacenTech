using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PermisoUsuarios
    {
        [Key]
        public int IdPermiso { get; set; }
        public string Detalle { get; set; }

        public PermisoUsuarios()
        {

        }


    }
}
