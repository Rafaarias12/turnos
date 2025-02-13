using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Ruta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public Operacion Operaciones { get; set; }
        public int OperacionId { get; set; }
        public ICollection<Ruta_Turno> Ruta_Turnos { get; set; }

    }
}
