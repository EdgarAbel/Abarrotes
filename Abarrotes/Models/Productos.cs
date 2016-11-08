using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abarrotes.Models
{
    public class Productos
    {
        [Key]
        public int ProductoID { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public int ProveedorID { get; set; }

        public int EmpresaID { get; set; }

        public virtual Empresa Empresas { get; set; }
    }
}