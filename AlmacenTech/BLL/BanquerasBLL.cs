using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BanquerasBLL
    {
        public static bool Insertar(Banqueras B)
        {
            bool retorno = false;
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.Banqueras.Add(B);
                    db.SaveChanges();
                    db.Dispose();
                    retorno = true;
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }

            return retorno;


        }

        public static Banqueras Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.Banqueras.Find(id);

        }

        public static void Eliminar(int id)
        {
            var db = new AlmacenBancasDB();

            Banqueras b = db.Banqueras.Find(id);
            db.Banqueras.Remove(b);
            db.SaveChanges();
        }

        public static void Actualizar(int id, Banqueras banquera)
        {
            var db = new AlmacenBancasDB();

            Banqueras b = db.Banqueras.Find(id);
            b.Celular = banquera.Celular;
            b.Direccion = banquera.Direccion;
            b.Fecha = banquera.Fecha;
            b.Nombres = banquera.Nombres;
            b.Telefono = banquera.Telefono;
            b.Sexo = banquera.Sexo;
            b.Cedula = banquera.Cedula;

            db.SaveChanges();
        }

        public static List<Banqueras> GetLista()
        {
            List<Banqueras> lista = new List<Banqueras>();

            var db = new AlmacenBancasDB();

            lista = db.Banqueras.ToList();

            return lista;

        }

        public static List<Banqueras> GetListaId(int id)
        {
            List<Banqueras> lista = new List<Banqueras>();

            var db = new AlmacenBancasDB();

            lista = db.Banqueras.Where(p => p.BanqueraId == id).ToList();

            return lista;

        }

        public static List<Banqueras> GetListaApellido(string a)
        {
            List<Banqueras> lista = new List<Banqueras>();

            var db = new AlmacenBancasDB();

            lista = db.Banqueras.Where(p => p.Apellidos == a).ToList();

            return lista;

        }

    }
}
