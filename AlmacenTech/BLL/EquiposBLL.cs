using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class EquiposBLL
    {
        public static void AgregarEquipo(Equipos eq)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.equipo.Add(eq);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }


        }

        public static Equipos Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.equipo.Find(id);

        }

        public static void EliminarEquipo(int id)
        {
            var db = new AlmacenBancasDB();

            Equipos u = (from p in db.equipo
                          where id == p.EquipoId
                          select p).FirstOrDefault();
            db.equipo.Remove(u);
            db.SaveChanges();
        }

        public static void ActualizarEquipo(int id, string MarcaEquipo, string SerialEquipo, int TipoEquipo )
        {
            var db = new AlmacenBancasDB();

            Equipos eq = (from p in db.equipo
                          where id == p.EquipoId
                          select p).FirstOrDefault();
            eq.MarcaEquipo = MarcaEquipo;
            eq.SerialNum = SerialEquipo;
            eq.TipoId = TipoEquipo;
            db.SaveChanges();
        }

        public static List<Equipos> GetLista()
        {
            List<Equipos> lista = new List<Equipos>();

            var db = new AlmacenBancasDB();

            lista = db.equipo.ToList();

            return lista;

        }

        public static List<Equipos> GetListaId(int id)
        {
            List<Equipos> lista = new List<Equipos>();

            var db = new AlmacenBancasDB();

            lista = db.equipo.Where(p => p.EquipoId == id).ToList();

            return lista;

        }

    }
}
