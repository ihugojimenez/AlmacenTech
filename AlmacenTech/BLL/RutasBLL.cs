using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class RutasBLL
    {
        public static void AgregaRutas(Rutas r)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.Rutas.Add(r);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }


        }

        public static Rutas Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.Rutas.Find(id);

        }

        public static void EliminarRutas(int id)
        {
            var db = new AlmacenBancasDB();

            Rutas r = (from p in db.Rutas
                       where id == p.RutaId
                        select p).FirstOrDefault();
            db.Rutas.Remove(r);
            db.SaveChanges();
        }

        public static void ActualizarRutas(int id, int mensajeroid, string direccion ,string ciudad, string referencia)
        {
            var db = new AlmacenBancasDB();

            Rutas r = (from p in db.Rutas
                       where id == p.RutaId
                       select p).FirstOrDefault();
            r.Ciudad = ciudad;
            r.Direccion = direccion;
            r.MensajeroId = mensajeroid;
            r.Referencia = referencia;
           


        }

        public static List<Rutas> GetLista()
        {
            List<Rutas> lista = new List<Rutas>();

            var db = new AlmacenBancasDB();

            lista = db.Rutas.ToList();

            return lista;

        }

        public static List<Rutas> GetListaId(int id)
        {
            List<Rutas> lista = new List<Rutas>();

            var db = new AlmacenBancasDB();

            lista = db.Rutas.Where(p => p.RutaId == id).ToList();

            return lista;

        }
    }
}
