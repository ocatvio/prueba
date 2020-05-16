using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pruebaRepositorioWeb.Models
{
    public class producto
    {
        [Key]
        public int ProductoID { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaUltimaCompra { get; set; }
        public float Cantidad { get; set; }
    }
}