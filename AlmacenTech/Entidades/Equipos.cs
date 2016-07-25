using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipos
    {
        [Key]
        public int EquipoId { get; set; }
        public string MarcaEquipo { get; set; }
        public int TipoId { get; set; }
        public string SerialNum { get; set; }

        public Equipos()
        {

        }

        public virtual TiposEquipos TiposEquipos { get; set; }
    }
}
