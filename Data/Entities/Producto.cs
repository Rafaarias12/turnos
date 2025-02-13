using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string tipo_peso { get; set; }

        public ICollection<Carga> Cargas { get; set; }
        public ICollection<Zona> Zonas { get; set; }
        public ICollection<Operacion> Operaciones { get; set; }

    }
}
