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
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public string Serial { get; set; }

        public Equipos()
        {

        }
    }
}
