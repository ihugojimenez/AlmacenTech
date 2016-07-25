using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TiposEquiposBLL
    {
        public static void AgregarTipoEquipo(TiposEquipos TE)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.TiposEquipos.Add(TE);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }


        }

        public static TiposEquipos Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.TiposEquipos.Find(id);

        }

        public static void EliminarTipoEquipo(int id)
        {
            var db = new AlmacenBancasDB();

            TiposEquipos TE = (from p in db.TiposEquipos
                         where id == p.TipoId
                         select p).FirstOrDefault();
            db.TiposEquipos.Remove(TE);
            db.SaveChanges();
        }

        public static void ActualizarTipoEquipo(int id, string Detalle)
        {
            var db = new AlmacenBancasDB();

            TiposEquipos TE = (from p in db.TiposEquipos
                          where id == p.TipoId
                          select p).FirstOrDefault();
            TE.Detalle = Detalle;
            db.SaveChanges();
        }

        public static List<TiposEquipos> GetLista()
        {
            List<TiposEquipos> lista = new List<TiposEquipos>();

            var db = new AlmacenBancasDB();

            lista = db.TiposEquipos.ToList();

            return lista;

        }

    }
}
