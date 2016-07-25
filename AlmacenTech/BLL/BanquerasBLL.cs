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
        public static void AgregarBanqueras(Banqueras B)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.Banqueras.Add(B);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }


        }

        public static Banqueras Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.Banqueras.Find(id);

        }

        public static void EliminarBanqueras(int id)
        {
            var db = new AlmacenBancasDB();

            Banqueras b = (from p in db.Banqueras
                         where id == p.BanqueraId
                         select p).FirstOrDefault();
            db.Banqueras.Remove(b);
            db.SaveChanges();
        }

        public static void ActualizarBanqueras(int id, string nombre, string Direccion, string celular, string telefono, DateTime fecha, bool sex)
        {
            var db = new AlmacenBancasDB();

            Banqueras b = (from p in db.Banqueras
                          where id == p.BanqueraId
                          select p).FirstOrDefault();
            b.Celular = celular;
            b.Direccion = Direccion;
            b.Fecha = fecha;
            b.Nombres = nombre;
            b.Telefono = telefono;
            b.Sexo = sex;
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


    }
}
