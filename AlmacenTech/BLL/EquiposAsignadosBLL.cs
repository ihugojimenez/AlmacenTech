using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class EquiposAsignadosBLL
    {
        public static void Insertar(EquiposAsignados EA)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.EquiposAsignados.Add(EA);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }


        }

        public static EquiposAsignados Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.EquiposAsignados.Find(id);

        }

        public static void Eliminar(int id)
        {
            var db = new AlmacenBancasDB();
            EquiposAsignados eq = db.EquiposAsignados.Find(id);

            db.EquiposAsignados.Remove(eq);
            db.SaveChanges();
        }

        public static void Actualizar(int id, EquiposAsignados equipo)
        {
            var db = new AlmacenBancasDB();

            EquiposAsignados eq = db.EquiposAsignados.Find(id);
            eq.Equipos = equipo.Equipos;
            db.SaveChanges();
        }

        public static List<EquiposAsignados> GetLista()
        {
            List<EquiposAsignados> lista = new List<EquiposAsignados>();

            var db = new AlmacenBancasDB();

            lista = db.EquiposAsignados.ToList();

            return lista;

        }

        public static List<EquiposAsignados> GetListaEquipos(int id)
        {
            List<EquiposAsignados> lista = new List<EquiposAsignados>();

            var db = new AlmacenBancasDB();

            lista = db.EquiposAsignados.Where(p => p.IdEquiposAsignados == id &&  p.Equipos.Count >0).ToList();

            return lista;

        }

        public static List<EquiposAsignados> GetListaDetalle(string aux)
        {
            List<EquiposAsignados> lista = new List<EquiposAsignados>();

            var db = new AlmacenBancasDB();

            lista = db.EquiposAsignados.Where(p => p.Detalle == aux).ToList();

            return lista;

        }



    }
}
