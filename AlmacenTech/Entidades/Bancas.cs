using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bancas
    {
        [Key]
        public int BancaId { get; set; }
        public int BanqueraId { get; set; }
        public int EquipoId { get; set; }
        public int RutaId { get; set; }

        public Bancas()
        {

        }

        public virtual DbSet<Banqueras> Banqueras { get; set; }


    }
}
