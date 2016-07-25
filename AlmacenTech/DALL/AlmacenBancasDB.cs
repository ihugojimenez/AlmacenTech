using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class AlmacenBancasDB : DbContext
    {
        public AlmacenBancasDB() : base("name = AlmacenDbAux") 
        {
            
        }

        public virtual DbSet<Usuarios> usuario { get; set; }
        public virtual DbSet<Equipos> equipo { get; set; }
        public virtual DbSet<TiposEquipos> TiposEquipos { get; set; }
        public virtual DbSet<Mensajeros> Mensajeros { get; set; }
        public virtual DbSet<Banqueras> Banqueras { get; set; }


    }
}
