using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Zona
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string DesCorta { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }

    }
}
