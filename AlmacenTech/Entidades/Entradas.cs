﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entradas
    {
        [Key]
        public int EntradaId { get; set; }
        public int EquipoId { get; set; }

        public Entradas()
        {

        }
    }
}
