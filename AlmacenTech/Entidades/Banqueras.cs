using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banqueras
    {
        [Key]
        public int BanqueraId { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public string Sexo { get; set; }
        public string Apellidos { get; set; }
       
        public Banqueras()
        {

        }

        


    }
}
