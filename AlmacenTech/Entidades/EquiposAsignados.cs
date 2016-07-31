using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquiposAsignados
    {

        public EquiposAsignados()
        {
            this.Equipos = new List<Entidades.Equipos>();
        }

        [Key]
        public int IdEquiposAsignados { get; set; }
        public string Detalle { get; set; }

        public virtual List<Entidades.Equipos> Equipos { get; set; }
    }
}
