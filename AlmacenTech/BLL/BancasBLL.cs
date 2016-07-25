using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BancasBLL
    {
        public static void AgregarBancas(Bancas ba)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.Bancas.Add(ba);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch (Exception exx)
            {
                throw exx;
            }


        }

        public static Bancas Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.Bancas.Find(id);

        }

        public static void EliminarBancas(int id)
        {
            var db = new AlmacenBancasDB();

            Bancas b = (from p in db.Bancas
                         where id == p.BancaId
                         select p).FirstOrDefault();
            db.Bancas.Remove(b);
            db.SaveChanges();
        }

        public static void ActualizarBancas(int id, int banqueraId, int equipoid, int Rutaid)
        {
            var db = new AlmacenBancasDB();

            Bancas b = (from p in db.Bancas
                         where id == p.BancaId
                          select p).FirstOrDefault();
            b.BanqueraId = banqueraId;
            b.EquipoId = equipoid;
            b.RutaId = Rutaid;

           
        }

        public static List<Bancas> GetLista()
        {
            List<Bancas> lista = new List<Bancas>();

            var db = new AlmacenBancasDB();

            lista = db.Bancas.ToList();

            return lista;

        }

        public static List<Bancas> GetListaId(int id)
        {
            List<Bancas> lista = new List<Bancas>();

            var db = new AlmacenBancasDB();

            lista = db.Bancas.Where(p => p.BancaId == id).ToList();

            return lista;

        }
    }
}
