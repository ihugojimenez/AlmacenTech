using BLL;
using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class MensajerosBLL
    {
        public static void AgregarMensajero(Mensajeros M)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.Mensajeros.Add(M);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }


        }

        public static Mensajeros Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.Mensajeros.Find(id);

        }

        public static void EliminarMensajero(int id)
        {
            var db = new AlmacenBancasDB();

            Mensajeros m = (from p in db.Mensajeros
                         where id == p.MensajeroId
                         select p).FirstOrDefault();
            db.Mensajeros.Remove(m);
            db.SaveChanges();
        }

        public static void ActualizarMensajero(int id, string nombre, string cedula, string celular, string direccion, DateTime fecha, bool sexo, string telefono)
        {
            var db = new AlmacenBancasDB();

            Mensajeros m = (from p in db.Mensajeros
                          where id == p.MensajeroId
                          select p).FirstOrDefault();
            m.Nombre = nombre;
            m.Cedula = cedula;
            m.Celular = celular;
            m.Direccion = direccion;
            m.FechaNacimiento = fecha;
            m.Sexo = sexo;
            m.Telefono = telefono;
            db.SaveChanges();
        }

        public static List<Mensajeros> GetLista()
        {
            List<Mensajeros> lista = new List<Mensajeros>();

            var db = new AlmacenBancasDB();

            lista = db.Mensajeros.ToList();

            return lista;

        }

        public static List<Mensajeros> GetListaId(int id)
        {
            List<Mensajeros> lista = new List<Mensajeros>();

            var db = new AlmacenBancasDB();

            lista = db.Mensajeros.Where(p => p.MensajeroId == id).ToList();

            return lista;

        }


    }
}
