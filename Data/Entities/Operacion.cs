using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Operacion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Nombre { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public Producto Producto { get; set; }
        public int ProductoId { get; set; }
        public ICollection<Ruta> Rutas { get; set; }
        public ICollection<Operacion_Vehiculo> Operacion_Vehiculos { get; set; }
    }
}
