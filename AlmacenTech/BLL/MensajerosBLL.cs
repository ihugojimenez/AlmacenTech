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
        public static void Insertar(Mensajeros M)
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

        public static void Eliminar(int id)
        {
            var db = new AlmacenBancasDB();
            Mensajeros m = db.Mensajeros.Find(id);
            db.Mensajeros.Remove(m);
            db.SaveChanges();
        }

        public static void Actualizar(int id, Mensajeros mensajero)
        {
            var db = new AlmacenBancasDB();

            Mensajeros m = db.Mensajeros.Find(id);
            m.Nombre = mensajero.Nombre;
            m.Cedula = mensajero.Cedula;
            m.Celular = mensajero.Celular;
            m.Direccion = mensajero.Direccion;
            m.FechaNacimiento = mensajero.FechaNacimiento;
            m.Sexo = mensajero.Sexo;
            m.Telefono = mensajero.Telefono;
            m.Apellido = mensajero.Apellido;
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

        public static List<Mensajeros> GetListaApellido(string apellido)
        {
            List<Mensajeros> lista = new List<Mensajeros>();

            var db = new AlmacenBancasDB();

            lista = db.Mensajeros.Where(p => p.Apellido == apellido).ToList();

            return lista;

        }

        public static List<Mensajeros> GetListaCedula(string a)
        {
            List<Mensajeros> lista = new List<Mensajeros>();

            var db = new AlmacenBancasDB();

            lista = db.Mensajeros.Where(p => p.Cedula == a).ToList();

            return lista;

        }

    }
}
