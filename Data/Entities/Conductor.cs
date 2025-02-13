using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Conductor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Documento { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Licencia { get; set; }
        [Required]
        public string Telefono { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
