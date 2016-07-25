using DALL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UsuariosBLL
    {

        public static void AgregarUsuario(Usuarios u)
        {
            try
            {
                using (var db = new AlmacenBancasDB())
                {
                    db.usuario.Add(u);
                    db.SaveChanges();
                    db.Dispose();
                }
            }
            catch(Exception exx)
            {
                throw exx;
            }


        }

        public static Usuarios Buscar(int id)
        {
            var db = new AlmacenBancasDB();

            return db.usuario.Find(id);

        }

        public static void Eliminar(int id)
        {
            var db = new AlmacenBancasDB();

            Usuarios u = (from p in db.usuario
                          where id == p.UsuarioId
                          select p).FirstOrDefault();
            db.usuario.Remove(u);
            db.SaveChanges();
        }

        public static void Actualizar(int id,string nombre, string apellido, string usuario, string contraseña)
        {
            var db = new AlmacenBancasDB();

            Usuarios u = (from p in db.usuario
                          where id == p.UsuarioId
                          select p).FirstOrDefault();
            u.Apellido = apellido;
            u.Contraseña = contraseña;
            u.Nombre = nombre;
            u.NombreUsuario = usuario;
            db.SaveChanges();
        }

        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new AlmacenBancasDB();

            lista = db.usuario.ToList();

            return lista;

        }

        public static List<Usuarios> GetListaId(int id)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new AlmacenBancasDB();

            lista = db.usuario.Where(p=> p.UsuarioId==id).ToList();

            return lista;

        }
    }
}
