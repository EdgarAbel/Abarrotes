using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Abarrotes.Models
{
    public class Empresa
    {
        [Key]
        public int EmpresaID { get; set; }


        public string Nombre { get; set; }

        
        public string Telefono { get; set; }

        virtual public ICollection <Proveedores> Proveedor { get; set; }
        virtual public ICollection<Productos> Productos { get; set; }
    }
}