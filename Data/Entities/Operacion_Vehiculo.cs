using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Operacion_Vehiculo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public DateTime Hora { get; set; }
        [Required]
        public Operacion Operaciones { get; set; }
        public int OperacionId { get; set; }
        [Required]
        public Vehiculo Vehiculos { get; set; }
        public int VehiculoId { get; set; }


    }
}
