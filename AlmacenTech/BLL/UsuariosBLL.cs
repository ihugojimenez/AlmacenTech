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

        public static void Insertar(Usuarios u)
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
            Usuarios u = db.usuario.Find(id);
            
            db.usuario.Remove(u);
            db.SaveChanges();
        }

        public static void Actualizar(int id, Usuarios usuario)
        {
            var db = new AlmacenBancasDB();

            Usuarios u = db.usuario.Find(id);

            u.Apellido = usuario.Apellido;
            u.Contraseña = usuario.Contraseña;
            u.IdPermiso = usuario.IdPermiso;
            u.Nombre = usuario.Nombre;
            u.NombreUsuario = usuario.NombreUsuario;
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

        public static List<Usuarios> GetApellido(string n)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new AlmacenBancasDB();

            lista = db.usuario.Where(p => p.Apellido == n).ToList();

            return lista;

        }

        public static List<Usuarios> GetListaIdPermiso(int id)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new AlmacenBancasDB();

            lista = db.usuario.Where(p => p.IdPermiso == id).ToList();

            return lista;

        }


        public static List<Usuarios> GetListaNombreUsuario(string aux)
        {
            List<Usuarios> lista = new List<Usuarios>();

            var db = new AlmacenBancasDB();

            lista = db.usuario.Where(p => p.NombreUsuario == aux).ToList();

            return lista;

        }

        public static int Cantidad()
        {
//            int total = 0;

            var db = new AlmacenBancasDB();
            

            return db.usuario.Count();
        }


    }
}
