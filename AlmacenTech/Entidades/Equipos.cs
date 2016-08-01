using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipos
    {
        

        public Equipos()
        {
            this.EquiposAsignados = new HashSet<EquiposAsignados>();
        }

        [Key]
        public int EquipoId { get; set; }
        public string MarcaEquipo { get; set; }
        public int TipoId { get; set; }
        public string SerialNum { get; set; }
        public DateTime FechaIngreso { get; set; }

        [Browsable(false)]
        public virtual ICollection<EquiposAsignados> EquiposAsignados { get; set; }

        public Equipos(int EquipoId, string marca)
        {
            this.EquipoId = EquipoId;
            this.MarcaEquipo = marca;
            /*this.TipoId = tipo;
            this.SerialNum = serial;*/
            this.EquiposAsignados = new HashSet<EquiposAsignados>();
        }
        

        public virtual TiposEquipos TiposEquipos { get; set; }
        
    }
}
