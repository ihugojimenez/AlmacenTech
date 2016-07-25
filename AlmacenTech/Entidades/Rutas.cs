using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rutas
    {
        [Key]
        public int RutaId { get; set; }
        public int MensajeroId { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        
        public string Referencia { get; set; }

        public Rutas()
        {

        }

        public virtual DbSet<Mensajeros> Mensajeros { get; set; }
    }
}
