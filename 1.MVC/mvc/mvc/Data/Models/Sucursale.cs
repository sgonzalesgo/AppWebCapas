﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace mvc.Data.Models
{
    public partial class Sucursale
    {
        public int Id { get; set; }
        public string Sucursal { get; set; }
        public int IdDirecciones { get; set; }

        public virtual Direccione IdDireccionesNavigation { get; set; }
    }
}