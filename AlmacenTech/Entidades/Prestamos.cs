using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }
        public int EquipoId { get; set; }
        public int MensajeroId { get; set; }
        public int BancaId { get; set; }
        public DateTime FechaSalida { get; set; }

        public Prestamos()
        {

        }

    }
}
