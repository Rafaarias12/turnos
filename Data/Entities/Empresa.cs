using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Nit { get; set; }
        [Required]
        public string Contacto { get; set; }
        [Required]
        public string NombreContacto { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
