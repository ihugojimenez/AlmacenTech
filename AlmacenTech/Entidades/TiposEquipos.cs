﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TiposEquipos
    {
        public TiposEquipos()
        {

        }

        [Key]
        public int TipoId { get; set; }
        public string Detalle { get; set; }

        public override string ToString()
        {
            return this.Detalle;
        }
        
    }
}
