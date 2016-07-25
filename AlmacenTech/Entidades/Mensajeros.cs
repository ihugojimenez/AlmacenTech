using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mensajeros
    {
        public Mensajeros()
        {

        }

        [Key]
        public int MensajeroId { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Sexo { get; set; }
    }
}
