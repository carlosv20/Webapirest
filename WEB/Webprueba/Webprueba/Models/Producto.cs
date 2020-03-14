using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Webprueba.Models
{
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }

        public char Nombre { get; set; }

        public int Cantidad { get; set; }

    }
}
