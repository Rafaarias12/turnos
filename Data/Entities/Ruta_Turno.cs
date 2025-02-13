using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Ruta_Turno
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public string Interruptor { get; set; }
        [Required]
        public Ruta Rutas { get; set; }
        public int RutaId { get; set; }
    }
}
