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
        public static void Insertar(Equipos eq)
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

        public static void Eliminar(int id)
        {
            var db = new AlmacenBancasDB();
            Equipos eq = db.equipo.Find(id);

            db.equipo.Remove(eq);
            db.SaveChanges();
        }

        public static void Actualizar(int id, Equipos equipo)
        {
            var db = new AlmacenBancasDB();

            Equipos eq = db.equipo.Find(id);
            eq.MarcaEquipo = equipo.MarcaEquipo;
            eq.SerialNum = equipo.SerialNum;
            eq.TipoId = equipo.TipoId;
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


        public static List<Equipos> GetListaMarca(string m)
        {
            List<Equipos> lista = new List<Equipos>();

            var db = new AlmacenBancasDB();

            lista = db.equipo.Where(p => p.MarcaEquipo == m).ToList();

            return lista;

        }

        public static List<Equipos> GetListaTipo(int tipoid)
        {
            List<Equipos> lista = new List<Equipos>();

            var db = new AlmacenBancasDB();

            lista = db.equipo.Where(p => p.TipoId == tipoid).ToList();

            return lista;

        }

        public static List<Equipos> GetListaSerial(string aux)
        {
            List<Equipos> lista = new List<Equipos>();

            var db = new AlmacenBancasDB();

            lista = db.equipo.Where(p => p.SerialNum == aux).ToList();

            return lista;

        }


    }
}
