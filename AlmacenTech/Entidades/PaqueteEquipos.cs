using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PaqueteEquipos
    {
        public int Id { get; set; }
        public int EquipoId { get; set; }
        public int IdEquiposAsignados { get; set; }

        public PaqueteEquipos()
        {

        }

        public virtual Equipos Equipos { get; set; }
        public virtual EquiposAsignados EquiposAsignados { get; set; }
    }
}
