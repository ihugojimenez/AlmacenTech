﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class AlmacenBancasDB : DbContext
    {
        public AlmacenBancasDB() : base("name = AlmacenDb") 
        {
            
        }

        public virtual DbSet<Usuarios> usuario { get; set; }
    }
}
