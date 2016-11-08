using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abarrotes.Models
{
    public class Proveedores
    {
        [Key]
        public int ProveedorID { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        virtual public Empresa Empresas { get; set; }

    }
}