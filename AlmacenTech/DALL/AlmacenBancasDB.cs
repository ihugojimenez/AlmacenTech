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
        public virtual DbSet<Bancas> Bancas { get; set; }
        public virtual DbSet<Rutas> Rutas { get; set; }
        public virtual DbSet<PermisoUsuarios> PermisoUsuarios { get; set; }
        public virtual DbSet<EquiposAsignados> EquiposAsignados { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<EquiposAsignados>()
               .HasMany<Equipos>(a => a.Equipos)
               .WithMany(p => p.EquiposAsignados)
               .Map(pa =>
               {
                   pa.MapLeftKey("idEquiposAsignados");
                   pa.MapRightKey("IdEquipo");
                   pa.ToTable("PaqueteEquipos");
               });

        }

    }
}
