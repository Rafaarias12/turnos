using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Carga
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Peso { get; set; }
        
        public Producto Productos { get; set; }
        [Required]
        public int ProductoId { get; set; }

    }
}
